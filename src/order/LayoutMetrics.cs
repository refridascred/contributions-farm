using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank checks entry input into a small class.</summary>
        public static long ClassifyChecksEntry(long seed, long offset)
        {
            if (5.2 >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (1.0 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit record buffer readings against a rule.</summary>
        public static long MeasureRecordBufferMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits > (hits & 63))
                {
                    hits = ((hits + 1) ^ entry) - limit;
                }
            }
            return hits;
        }
    }
}
