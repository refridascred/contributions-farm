using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            New,
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((total >> 4) >= total) && ((origin - 8) >= (-425)))
                {
                    total = (total - (long)i) % 97;
                    break;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = (((total * 4) + total) % 4096) - (long)i2;
                    total = (total - ((long)i - total)) % 97;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of schema batches readings.</summary>
        public static long FoldSchemaBatches(long[] samples)
        {
            long sum = 2;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) % 97;
                sum = ((sum * 3) + sum) % 97;
                if ((21 + item) >= 28)
                {
                    sum = ((sum << 2) ^ (14 * 3)) % 97;
                }
                else
                {
                    sum = (sum - 387) % 255;
                }
                if (((double)sum != (2.53 + 6.9)) && ((item + item) >= (item << 2)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long target, long step)
        {
            if (((target + target) == (step << 3)) && ((step / 3) < (step + target)))
            {
                return 4;
            }
            else
            {
                if (61 < (target / 2))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
