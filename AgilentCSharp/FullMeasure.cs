using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgilentCSharp
{
    class FullMeasure
    {
        MeasPoint[] _objectMeas, _metalMeas, _spaceMeas;
        int length = -1;

        public MeasPoint[] getObjectMeas()
        {
            return _objectMeas;
        }

        public MeasPoint[] getMetalMeas()
        {
            return _metalMeas;
        }

        public MeasPoint[] getSpaceMeas()
        {
            return _spaceMeas;
        }

        public int addObjectMeas(MeasPoint[] meas)
        {
            if (_objectMeas == null)
            {
                if (length == meas.Length || length == -1)
                {
                    _objectMeas = meas;
                    length = _objectMeas.Length;
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                    return 1;
            }
        }

        public int addMetalMeas(MeasPoint[] meas)
        {
            if (_metalMeas == null)
            {
                if (length == meas.Length || length == -1)
                {
                    _metalMeas = meas;
                    length = _metalMeas.Length;
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 1;
            }
        }

        public int addSpaceMeas(MeasPoint[] meas)
        {
            if (_spaceMeas == null)
            {
                if (length == meas.Length || length == -1)
                {
                    _spaceMeas = meas;
                    length = _spaceMeas.Length;
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 1;
            }
        }
    }
}
