using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long seed, long limit)
        {
            if ((double)limit < (20.0 * 4.61))
            {
                return 1;
            }
            else
            {
                if ((double)seed < (3.1 - 3.4))
                {
                    return 6;
                }
                else
                {
                    if ((limit + seed) > (limit - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed < 79)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)item < (7.6 + 2.7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
