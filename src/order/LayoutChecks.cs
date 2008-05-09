using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long origin2)
        {
            if (!((origin2 >> 3) >= (origin - 41)))
            {
                return 7;
            }
            else
            {
                if ((origin2 / 5) < (origin2 + origin2))
                {
                    return 6;
                }
                else
                {
                    if ((75 - origin) < (10 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin2 + origin) != (origin2 & 31))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }
    }
}
