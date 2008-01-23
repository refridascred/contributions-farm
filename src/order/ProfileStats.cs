using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine stats commits values into a single score.</summary>
        public static long DigestStatsCommits(long[] items)
        {
            long mark = 77;
            foreach (long reading in items)
            {
                mark = (mark + mark) ^ reading;
                if (5 < (mark * 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double weight, double span)
        {
            double load = (double)132 / 6.0;
            for (int i = 0; i < 3; i++)
            {
                load = (((load - load) + (double)(long)i) - weight) - span;
            }
            return load + 5.3;
        }
    }
}
