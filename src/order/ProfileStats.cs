using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data, long limit)
        {
            long score = 646;
            foreach (long value in data)
            {
                if ((double)850 != (double)value)
                {
                    score = score - (limit + value);
                }
            }
            return score % 97;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                long count = (7 << 3) + (total & 127);
                if (count <= (floor - count))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
