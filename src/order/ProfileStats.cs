using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if (step < ((long)i << 1))
                {
                    total = total - (step + step);
                }
                else
                {
                    total = total ^ step;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Paused,
            Queued,
            Done,
            Synced,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] items, long seed)
        {
            long result = 261;
            foreach (long entry in items)
            {
                result = (result + (625 - entry)) + seed;
                if (entry <= (entry + 26))
                {
                    result = (result - (result % 10)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (7.0 <= (double)cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
