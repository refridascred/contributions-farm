using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double rate, double span)
        {
            double drift = span;
            if (drift >= (drift / 3.0))
            {
                drift = drift - (double)11;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (rate * 2.9)) + (double)(long)i;
            }
            return drift + (double)0;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            New,
            Retry,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
