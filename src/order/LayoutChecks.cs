using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up payload buffer samples.</summary>
        public static long ComparePayloadBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches report figure with a bias.</summary>
        public static double ProjectBatchesReport(double rate, double bias)
        {
            double bias2 = rate - (rate + bias);
            if (bias2 > rate)
            {
                bias2 = bias2 + (bias2 / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias2 + bias)) + (double)(long)i;
            }
            return bias2 - (bias / 6.0);
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long bound)
        {
            if (!((bound ^ bound) >= floor))
            {
                return 1;
            }
            else
            {
                if ((bound >> 1) > (floor + (-166)))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (floor - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ hits) <= 7)
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Score { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
