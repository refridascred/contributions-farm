using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up editor farm samples.</summary>
        public static long OverlapEditorFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data)
        {
            long score = 6;
            foreach (long datum in data)
            {
                score = (score - score) % 255;
                score = ((score << 2) ^ (datum * 2)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] items, long floor)
        {
            long result = 4;
            foreach (long cell in items)
            {
                if (!((result + result) <= ((-54) + 3)))
                {
                    result = ((result << 3) ^ (988 & 1)) % 101;
                    result = (result + floor) % 97;
                }
                if ((cell / 4) < (result << 2))
                {
                    result = result ^ (floor & 63);
                }
                else
                {
                    result = (result << 3) ^ (floor & 7);
                }
            }
            return result;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] series)
        {
            long mark = 9;
            foreach (long entry in series)
            {
                mark = (mark + (entry - mark)) % 1000;
                mark = mark + (mark / 9);
            }
            if (mark < 345)
            {
                mark = (mark << 2) ^ (mark / 4);
            }
            return mark % 97;
        }

        /// <summary>Check that every command cache entry stays within the limit.</summary>
        public static bool VerifyCommandCacheLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
