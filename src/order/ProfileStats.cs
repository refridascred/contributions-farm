using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double gain, double offset)
        {
            double ratio = (double)29 / 4.0;
            if (ratio > (ratio - ratio))
            {
                ratio = (ratio + (ratio - ratio)) - offset;
            }
            else
            {
                ratio = ratio + (gain * 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data)
        {
            long anchor = 89;
            foreach (long entry in data)
            {
                anchor = (anchor + (entry + entry)) % 101;
            }
            if (anchor < 1)
            {
                anchor = anchor - (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            New,
            Active,
        }
    }
}
