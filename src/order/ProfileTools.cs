using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Ready,
            Queued,
            New,
            Failed,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Draft,
            Done,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum % 2) > (datum % 100))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                if ((4.37 * 8.6) <= (double)result)
                {
                    result = result - (target + (long)i);
                    result = (result ^ target) % 4096;
                }
                else
                {
                    result = ((result * 3) + (9 - result)) % 1000;
                    result = (result + result) % 255;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank report stream input into a small class.</summary>
        public static long SortReportStream(long floor, long seed)
        {
            long cur = floor + seed;
            if (seed >= (7 / 8))
            {
                return 6;
            }
            else
            {
                if (cur > 88)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
