using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a channel metrics value against two limits.</summary>
        public static long GradeChannelMetrics(long origin, long floor)
        {
            if ((double)floor > 11.0)
            {
                return 8;
            }
            else
            {
                if ((47 >> 5) > origin)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (double)819)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (366 << 2)) % 255;
                acc = (acc - (acc + 198)) % 1000;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
