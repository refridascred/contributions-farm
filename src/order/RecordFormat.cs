using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank counter batches input into a small class.</summary>
        public static long ClassifyCounterBatches(long seed, long seed2)
        {
            if (!(seed2 > (56 / 9)))
            {
                return 8;
            }
            else
            {
                if ((seed2 % 100) <= (seed2 << 2))
                {
                    return 2;
                }
                else
                {
                    if ((5.85 - 6.76) < (double)3)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Done,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of filter context readings.</summary>
        public static long MatchFilterContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
