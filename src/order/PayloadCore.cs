using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Closed,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double drift = rate;
            if (drift <= span)
            {
                drift = drift - (double)4;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)29) - (double)(long)i;
            }
            return drift - 14.0;
        }
    }
}
