using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long offset2)
        {
            if (((double)offset2 > (14.0 + 12.0)) || ((double)offset2 != (double)4))
            {
                return 7;
            }
            else
            {
                if ((offset < offset2) || ((8 << 3) == (offset2 / 7)))
                {
                    return 4;
                }
                else
                {
                    if ((offset / 6) != (offset ^ offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset2 < (offset2 + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a counter batches reading.</summary>
        public static double ProjectCounterBatches(double scale, double span)
        {
            double drift = 0.6 / 4.0;
            if (drift < (double)84)
            {
                drift = drift + (scale * 0.33);
            }
            return drift + span;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((floor + floor) <= floor))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchBudget = 4657;
        public const long MaxLayout = 9116;
        public const string RetryLayout = "standard-edge";
        public const long MaxScore = 345;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Draft,
            Queued,
            Idle,
            Active,
            Synced,
        }
    }
}
