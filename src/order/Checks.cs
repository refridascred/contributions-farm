using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Locked,
            Draft,
            Synced,
            New,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((5.23 + 5.4) <= (double)sample)
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

        /// <summary>Find the first filter batches entry that matches the target.</summary>
        public static long LookupFilterBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long origin2)
        {
            long step = origin ^ origin2;
            if ((origin2 > (origin2 * 3)) && (7 <= (origin * 3)))
            {
                return 5;
            }
            else
            {
                if ((origin + step) < (origin2 / 2))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 7) >= step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin ^ 87) < (origin2 >> 5))
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
        }
    }
}
