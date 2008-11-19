using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9735;
        public const long HardBatches = 9803;
        public const double CacheDepth = 95.67;
        public const string BatchLevel = "latest-1";

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Active,
            New,
        }

        /// <summary>Find the first session route entry that matches the target.</summary>
        public static long LocateSessionRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long target, long floor)
        {
            long edge = target + floor;
            if (edge >= (edge ^ target))
            {
                return 3;
            }
            else
            {
                if ((floor % 24) <= edge)
                {
                    return 2;
                }
                else
                {
                    if ((double)646 < (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!!((value - 3) < (matches & 63)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double bias = (double)(5 ^ 601);
            return ((bias + (double)6) + scale) + floor;
        }
    }
}
