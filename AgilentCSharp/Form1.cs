using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgilentPNA835x;

namespace AgilentCSharp
{
    public partial class Form1 : Form
    {
        Agilent agilent = null;
        //int pointnumber = 0;
        MeasPoint[] metalCal = null, spaceCal = null;
        List<MeasPoint[]> measPointList = new List<MeasPoint[]>();
        List<MeasPoint[]> measPointCalList = new List<MeasPoint[]>();
        List<GroupBox> toggleable_list = new List<GroupBox>();
        static string[] FREQS = {"Hz","KHz","MHz","GHz" };
        static int[] FREQM = { 1, 1000, 1000000, 1000000000 };
        static char[] NUMNINPUT = { '0','1','2','3','4','5','6','7','8','9','0','.','-',(char)Keys.Back};
        System.Globalization.NumberFormatInfo numformat = System.Globalization.NumberFormatInfo.InvariantInfo;
        Reference<MeasPoint[]> forSave = null;
            

        string FloatArrayToString(float[] array)
        {            
            String str="";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                str = str + array[i];
            }
            str += "\r\n";
            return str;
        }

        string FloatArrayToString(float[,] array)
        {
            String str = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1)-1; j++)
                {
                    str += array[i, 0] + "\t";
                }
                str += array[i, array.GetLength(1)-1] + "\r\n";
            }
            return str;
        }

        MeasPoint[] MakeMeasArray(float[,] array1,double startfreq, double stopfreq)
        {
            int len = array1.GetLength(0);
            MeasPoint[] measarray = new MeasPoint[len];
            double step = (stopfreq-startfreq)/(len-1);
            measarray[0] = new MeasPoint(startfreq,array1[0,0],array1[0,1]);
            for (int i = 1; i < len; i++)
            {
                measarray[i] = new MeasPoint(measarray[i-1].Frequency+step, array1[i,0],array1[i,1]);
            }
            return measarray;
        }

        MeasPoint[] SingleMeasurement()
        {
            //Agilent.agilent.CreateCustomMeasurementEx(1, "", "S11");
            //Agilent.agilent.CreateSParameter(1, 2, 1, 1);
            Agilent.agilent.ActiveChannel.Single(false);
            double startfreq = Agilent.agilent.ActiveChannel.StartFrequency;
            double stopfreq = Agilent.agilent.ActiveChannel.StopFrequency;
            return MakeMeasArray(agilent.GetComplexMeasure(), startfreq, stopfreq);
            
        }



        void PrintMeasurement(MeasPoint[] measarray,ref System.Windows.Forms.DataVisualization.Charting.Chart chrt,ref TextBox tbox)
        {
            String str = "";
            chrt.Series[0].Points.Clear();
            chrt.ChartAreas[0].AxisX.LabelStyle.Format = "#.####"+"MHz";
            chrt.ChartAreas[0].AxisY.LabelStyle.Format = "0"+"dB";
            if (measarray != null)
            {
                double scale = 1.0 / 1000000;
                chrt.ChartAreas[0].Axes[0].Minimum = (double)measarray[0].Frequency*scale;
                chrt.ChartAreas[0].Axes[0].Maximum = (double)measarray[measarray.Length-1].Frequency*scale;
                for (int i = 0; i < measarray.Length; i++)
                {

                    str += measarray[i].Frequency + "\t" + measarray[i].Complex.Real + "\t" + measarray[i].Complex.Imaginary + "\t" + measarray[i].LogMag + "\r\n\r\n";
                    chrt.Series[0].Points.AddXY((double)measarray[i].Frequency*scale, measarray[i].LogMag);
                }
            }
            if(tbox!=null) outText.Text = str;
        }

        void PrintMeasurement(MeasPoint[] measarray, ref System.Windows.Forms.DataVisualization.Charting.Chart chrt)
        {
            chrt.Series[0].Points.Clear();
            chrt.ChartAreas[0].AxisX.LabelStyle.Format = "#.####" + "MHz";
            chrt.ChartAreas[0].AxisY.LabelStyle.Format = "0" + "dB";
            if (measarray != null)
            {
                double scale = 1.0 / 1000000;
                chrt.ChartAreas[0].Axes[0].Minimum = (double)measarray[0].Frequency * scale;
                chrt.ChartAreas[0].Axes[0].Maximum = (double)measarray[measarray.Length - 1].Frequency * scale;
                for (int i = 0; i < measarray.Length; i++)
                {
                    chrt.Series[0].Points.AddXY((double)measarray[i].Frequency * scale, measarray[i].LogMag);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            toggleable_list.Add(bandwidthOptionsGroup);
            toggleable_list.Add(spaceCalGroup);
            toggleable_list.Add(metalCalGroup);
            toggleable_list.Add(freqOptionsGroup);
            toggleable_list.Add(graphGroup);
            toggleable_list.Add(measListGroup);
            toggleable_list.Add(measureButtonsGroup);
            toggleable_list.Add(outTextGroup);
            toggleable_list.Add(outputGroup);
            toggleable_list.ForEach(
                (el) =>
                {
                    el.Enabled = false;
                }
                );
                measList.Items.Add("Новое измерение", false);
                measPointList.Add(null);
                measPointCalList.Add(null);
                measList.SelectedIndex = measList.Items.Count - 1;
                startFreqMultiplierBox.Items.Clear();
                stopFreqMultiplierBox.Items.Clear();
                foreach (string s in FREQS)
                {
                    startFreqMultiplierBox.Items.Add(s);
                    stopFreqMultiplierBox.Items.Add(s);
                }
                //Agilent.agilent.OnChannelEvent += onChannelEvent_proc;
        }
        //delegate measurementMade(object sender, EventArgs e);

        MeasPoint[] CalMeas(MeasPoint[] src, MeasPoint[] metal, MeasPoint[] space)
        {
            MeasPoint[] res = new MeasPoint[src.Length];
            for (int i = 0; i < src.Length; i++)
            {
                res[i] = new MeasPoint(src[i].Frequency,(src[i].Complex - space[i].Complex) / (metal[i].Complex - space[i].Complex));
            }
            return res;
        }


        void button1_Click(object sender, EventArgs e)
        {
            if (measList.SelectedIndex >= 0)
            {
                int curindex = measList.SelectedIndex;
                MeasPoint[] meas = SingleMeasurement();
                measPointList[curindex] = meas;
                MeasPoint[] measCal = null;
                if (metalCal != null && spaceCal != null)
                {
                    measCal = CalMeas(meas, metalCal, spaceCal);
                }
                measPointCalList[curindex] = measCal;
                if (withCalCheckbox.Checked)
                {
                    PrintMeasurement(measCal, ref measGraphic, ref outText);
                }
                else
                {
                    PrintMeasurement(meas, ref measGraphic, ref outText);
                }
                int selindex = measList.SelectedIndex;
                measList.Items.RemoveAt(selindex);
                measList.Items.Insert(selindex, System.DateTime.Now.ToShortDateString()+"_"+System.DateTime.Now.Hour+"-"+System.DateTime.Now.Minute+"-"+System.DateTime.Now.Second);
                measList.SelectedIndex = selindex;
                if (measList.SelectedIndex == measList.Items.Count - 1)
                {
                    measList.Items.Add("Новое измерение", false);
                    measPointList.Add(null);
                    measPointCalList.Add(null);
                }
            }
            else
            {
                measList.Items.Add("Новое измерение", false);
                measPointList.Add(null);
                measPointCalList.Add(null);
                measList.SelectedIndex = measList.Items.Count - 1;
                button1_Click(sender, e);
            }
                        
        }

        void outputbox_TextChanged(object sender, EventArgs e)
        {

        }

        void chart1_Click(object sender, EventArgs e)
        {

        }

        void measList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (measList.SelectedIndex >= 0)
            {
                if (withCalCheckbox.Checked)
                {
                    if (measPointCalList[measList.SelectedIndex] == null && measList.SelectedIndex < measList.Items.Count - 1)
                    {
                        measPointCalList[measList.SelectedIndex] = CalMeas(measPointList[measList.SelectedIndex], metalCal, spaceCal);
                    }
                    PrintMeasurement(measPointCalList[measList.SelectedIndex], ref measGraphic, ref outText);
                }
                else
                {
                    PrintMeasurement(measPointList[measList.SelectedIndex], ref measGraphic, ref outText);
                }
            }
        }

        void measList_SelectedValueChanged(object sender, EventArgs e)
        {
            PrintMeasurement(measPointList[measList.SelectedIndex], ref measGraphic,ref outText);
        }

        private void measureSpaceButton_Click(object sender, EventArgs e)
        {
            spaceCal = SingleMeasurement();
            PrintMeasurement(spaceCal, ref spaceGraphic);
            saveCSVSpace.Enabled = true;
            saveS1PSpace.Enabled = true;
            if (spaceCal != null && metalCal != null)
            {
                for (int i = 0; i < measPointCalList.Count; i++)
                {
                    measPointCalList[i] = null;
                }
                withCalCheckbox.Enabled = true;
            }
        }

        private void measureMetalButton_Click(object sender, EventArgs e)
        {
            metalCal = SingleMeasurement();
            PrintMeasurement(metalCal, ref metalGraphic);
            saveCSVMetal.Enabled = true;
            saveS1PMetal.Enabled = true;
            if (spaceCal != null && metalCal != null)
            {
                for (int i = 0; i < measPointCalList.Count; i++)
                {
                    measPointCalList[i] = null;
                }
                withCalCheckbox.Enabled = true;
            }
        }

        private void startFreqMultiplierBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void stopFreqMultiplierBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void startFreqField_ValueChanged(object sender, EventArgs e)
        {

        }

        private void stopFreqField_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startFreqField_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void setMeasurementOptions_Click(object sender, EventArgs e)
        {
            Agilent.agilent.ActiveChannel.IFBandwidth = Double.Parse(bandwidthField.Text,numformat);
            Agilent.agilent.ActiveChannel.StartFrequency = Double.Parse(startFreqField.Text,numformat) * FREQM[startFreqMultiplierBox.SelectedIndex];
            Agilent.agilent.ActiveChannel.StopFrequency = Double.Parse(stopFreqField.Text,numformat) * FREQM[stopFreqMultiplierBox.SelectedIndex];
            Agilent.agilent.ActiveChannel.NumberOfPoints = (int)pointNumberField.Value;
            Agilent.agilent.ActiveChannel.TestPortPower[1] = Double.Parse(powerField.Text, numformat);
            recieveMeasurementOptions();
        }

        private void recieveMeasurementOptions()
        {
            startFreqMultiplierBox.SelectedIndex = (int)Math.Floor(Math.Log(Agilent.agilent.ActiveChannel.StartFrequency, 1000));
            startFreqField.Text = (Agilent.agilent.ActiveChannel.StartFrequency / FREQM[startFreqMultiplierBox.SelectedIndex]).ToString(numformat);
            stopFreqMultiplierBox.SelectedIndex = (int)Math.Floor(Math.Log(Agilent.agilent.ActiveChannel.StopFrequency, 1000));
            stopFreqField.Text = (Agilent.agilent.ActiveChannel.StopFrequency / FREQM[stopFreqMultiplierBox.SelectedIndex]).ToString(numformat);
            pointNumberField.Value = (decimal)(Agilent.agilent.ActiveChannel.NumberOfPoints);
            bandwidthField.Text = Agilent.agilent.ActiveChannel.IFBandwidth.ToString(numformat);
            powerField.Text = Agilent.agilent.ActiveChannel.TestPortPower[1].ToString(numformat);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPageIndex == 0 && agilent!=null){
                recieveMeasurementOptions();
            }
        }

        private void onChannelEvent_proc(object eventId, object channel)
        {
            throw new NotImplementedException();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                agilent = new Agilent(addressField.Text);
            }
            catch (System.Runtime.InteropServices.COMException exc)
            {
                throw exc;
            }
            if (agilent != null)
            {
                toggleable_list.ForEach(
                    (elmt)=>
                        {
                            elmt.Enabled = true;
                        }
                    );
                connectGroup.Enabled = false;
                recieveMeasurementOptions();
                //Agilent.agilent.OnChannelEvent += onChannelEvent_proc;
                //Agilent.agilent.OnMeasurementEvent += onChannelEvent_proc;
            }
        }

        private void withCalCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (withCalCheckbox.Checked)
            {
                if (measPointCalList[measList.SelectedIndex] == null && measPointList[measList.SelectedIndex] != null)
                {
                    measPointCalList[measList.SelectedIndex] = CalMeas(measPointList[measList.SelectedIndex], metalCal, spaceCal);
                }
                PrintMeasurement(measPointCalList[measList.SelectedIndex], ref measGraphic, ref outText);
            }
            else
            {
                PrintMeasurement(measPointList[measList.SelectedIndex], ref measGraphic, ref outText);
            }
        }

        private void outputGroup_Enter(object sender, EventArgs e)
        {

        }

        private void numericFieldKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!NUMNINPUT.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void saveCSVSpace_Click(object sender, EventArgs e)
        {
            forSave = new Reference<MeasPoint[]>(spaceCal);
            saveCSVDialog.ShowDialog();
        }

        private void saveS1PSpace_Click(object sender, EventArgs e)
        {
            forSave = new Reference<MeasPoint[]>(spaceCal);
            saveS1PDialog.ShowDialog();
        }

        private void saveCSVMetal_Click(object sender, EventArgs e)
        {
            forSave = new Reference<MeasPoint[]>(metalCal);
            saveCSVDialog.ShowDialog();
        }

        private void saveS1PMetal_Click(object sender, EventArgs e)
        {
            forSave = new Reference<MeasPoint[]>(metalCal);
            saveS1PDialog.ShowDialog();
        }

        private void saveS1PDialog_FileOk(object sender, CancelEventArgs e)
        {
            saveToS1P(saveS1PDialog.FileName);
        }

        private void saveCSVDialog_FileOk(object sender, CancelEventArgs e)
        {
            saveToCSV(saveCSVDialog.FileName);
        }

        private void saveToS1P(string filename)
        {
            string texttowrite = "#Agilent C-sharp 2015\r\n#.S1P format file\r\n#Created at " + DateTime.Now + "\r\n#Freq Hz\tS dB";
            foreach (MeasPoint mp in forSave.Contains as MeasPoint[])
            {
                texttowrite += "\r\n"+mp.Frequency.ToString(numformat)+" "+mp.LogMag.ToString(numformat);
            }
            System.IO.File.WriteAllText(filename, texttowrite);
        }
        
        private void saveToCSV(string filename)
        {
            string texttowrite = "\"Freq [Ghz]\",\"db(S(WavePort1,WavePort1)) []\"";
            foreach (MeasPoint mp in forSave.Contains as MeasPoint[])
            {
                texttowrite += "\r\n" + (mp.Frequency/1000000000).ToString(numformat) + "," + mp.LogMag.ToString(numformat);
            }
            System.IO.File.WriteAllText(filename, texttowrite);
        }

        private void saveCSVButton_Click(object sender, EventArgs e)
        {
            saveMassCSVDialog.ShowDialog();
        }

        private void saveMassCSVDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (measList.SelectedItems.Count > 0)
            {
                if (withCalCheckbox.Checked)
                {
                    foreach (int indc in measList.CheckedIndices)
                    {
                        forSave = new Reference<MeasPoint[]>(measPointCalList[indc]);
                        saveToCSV(saveMassCSVDialog.FileName.Remove(saveMassCSVDialog.FileName.Length - 4) + "_" + measList.Items[indc] + "_cal.csv");
                    }
                }
                else
                {
                    foreach (int indc in measList.CheckedIndices)
                    {
                        forSave = new Reference<MeasPoint[]>(measPointList[indc]);
                        saveToCSV(saveMassCSVDialog.FileName.Remove(saveMassCSVDialog.FileName.Length - 4) + "_" + measList.Items[indc] + ".csv");
                    }
                }
            }
        }

        private void saveS1PButton_Click(object sender, EventArgs e)
        {
            saveMassS1PDialog.ShowDialog();
        }

        private void saveMassS1PDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (measList.SelectedItems.Count > 0)
            {
                if (withCalCheckbox.Checked)
                {
                    foreach (int indc in measList.CheckedIndices)
                    {
                        forSave = new Reference<MeasPoint[]>(measPointCalList[indc]);
                        saveToS1P(saveMassS1PDialog.FileName.Remove(saveMassS1PDialog.FileName.Length - 4) + "_" + measList.Items[indc] + "_cal.s1p");
                    }
                }
                else
                {
                    foreach (int indc in measList.CheckedIndices)
                    {
                        forSave = new Reference<MeasPoint[]>(measPointList[indc]);
                        saveToS1P(saveMassS1PDialog.FileName.Remove(saveMassS1PDialog.FileName.Length - 4) + "_" + measList.Items[indc] + ".s1p");
                    }
                }
            }
        }
                
    }
}
