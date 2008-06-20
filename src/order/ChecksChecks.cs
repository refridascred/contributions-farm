using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a payload session counter forward.</summary>
        public static long StepPayloadSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = (state ^ (state >> 4)) % 101;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double rate, double floor)
        {
            double gain = floor + rate;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + (gain + gain);
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
