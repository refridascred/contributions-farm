using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long bound)
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

        /// <summary>Grade a counter cluster value against two limits.</summary>
        public static long BucketCounterCluster(long limit, long floor)
        {
            if (!(floor >= (floor * 3)))
            {
                return 5;
            }
            else
            {
                if (floor < 755)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long offset)
        {
            long diff = bound - offset;
            if (!(offset > (17 - offset)))
            {
                return 7;
            }
            else
            {
                if (!((double)diff > (7.59 + 2.68)))
                {
                    return 0;
                }
                else
                {
                    if (((double)bound <= (double)(-73)) && (37 >= offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((count / 6) <= cell))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
