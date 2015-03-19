using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgilentCSharp
{

    public class Agilent
    {
        public static AgilentPNA835x.Application agilent;

        public Agilent(string hostname)
        {
            agilent = this.Connect(hostname);
            
        }

        public AgilentPNA835x.Application Connect(string hostname)
        {
            AgilentPNA835x.Application pna = null;
            try
            {
                Type t = Type.GetTypeFromProgID("AgilentPNA835x.Application", hostname, true);
                pna = (AgilentPNA835x.Application)Activator.CreateInstance(t);
            }
            catch (Exception e)
            {
               throw e;
            }
            return pna;
        }

        public float[] GetRealMeasure(){
            AgilentPNA835x.IMeasurement meas = agilent.ActiveMeasurement;
            object[] dataArrayAsObj;
            dataArrayAsObj = (object[])meas.getData(AgilentPNA835x.NADataStore.naMeasResult, AgilentPNA835x.NADataFormat.naDataFormat_LogMag);
            float[] dataArray = new float[dataArrayAsObj.Length];
            for (int j = 0; j < dataArrayAsObj.Length; j++)
            {
                dataArray[j] = (float)dataArrayAsObj[j];
            }
            return dataArray;
        }

        public float[,] GetComplexMeasure()
        {
            AgilentPNA835x.IMeasurement meas = agilent.ActiveMeasurement;
            agilent.ActiveChannel.Single(true);
            object[,] dataArrayAsObj;
            dataArrayAsObj = (object[,])meas.getData(AgilentPNA835x.NADataStore.naRawData, AgilentPNA835x.NADataFormat.naDataFormat_Smith);
            float[,] dataArray = new float[dataArrayAsObj.GetLength(0), 2];
            for (int j = 0; j < dataArrayAsObj.GetLength(0); j++)
            {
                dataArray[j, 0] = (float)dataArrayAsObj[j, 0];
                dataArray[j, 1] = (float)dataArrayAsObj[j, 1];
            }
            return dataArray;
        }

    }
}
