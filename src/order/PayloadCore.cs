using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double offset)
        {
            double mean = offset;
            if (mean < (double)61)
            {
                mean = (mean + (double)12) - gain;
            }
            return mean + (double)40;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            New,
            Retry,
        }
    }
}
