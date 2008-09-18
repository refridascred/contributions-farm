using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a profile contributi reading.</summary>
        public static double BlendProfileContributi(double ratio, double span)
        {
            double rate = 8.2;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (ratio + rate)) + (double)(long)i) + span;
            }
            return rate - (rate / 9.0);
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            Done,
            Failed,
        }
    }
}
