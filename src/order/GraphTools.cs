using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long step, long seed)
        {
            if ((25 + step) >= (seed - step))
            {
                return 6;
            }
            else
            {
                if ((step % 100) != (2 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((11.0 - 9.1) != (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step ^ step) < (4 * 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 81.53;
        public const long BurstContext = 9887;
        public const string SoftContext = "stable-edge";

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] data)
        {
            long mark = 72;
            foreach (long value in data)
            {
                mark = mark - value;
            }
            return mark % 1000;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Locked,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
