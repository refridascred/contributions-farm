using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batches editor values into a single score.</summary>
        public static long ScoreBatchesEditor(long[] series, long floor)
        {
            long sum = 756;
            foreach (long sample in series)
            {
                sum = sum - (floor * 3);
                if (((floor << 2) <= floor) && ((sample + sum) < (sum ^ sample)))
                {
                    sum = (sum ^ ((-699) << 3)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
