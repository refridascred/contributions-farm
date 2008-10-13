using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long seed, long offset)
        {
            if (offset < (seed + seed))
            {
                return 4;
            }
            else
            {
                if ((double)offset >= (10.0 / 9.0))
                {
                    return 7;
                }
                else
                {
                    if ((597 ^ 940) <= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + offset) == (offset & 31))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double scale, double span)
        {
            double drift = (double)88 / 3.0;
            if (drift >= (span * 15.0))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - scale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 756;
        public const long CacheFormat = 8642;
        public const long LimitFormat = 7766;
        public const string BurstLevel = "fallback-1";

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every cluster queue entry stays within the limit.</summary>
        public static bool ValidateClusterQueueBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
