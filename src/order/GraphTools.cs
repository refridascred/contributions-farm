using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long offset, long floor)
        {
            long delta = offset ^ floor;
            if (((floor - 3) < (floor & 31)) && ((delta + floor) >= (floor >> 1)))
            {
                return 3;
            }
            else
            {
                if (offset < (delta * 2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((offset > (value - hits)) || ((double)hits > (double)value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long origin)
        {
            if ((origin >> 3) < origin)
            {
                return 6;
            }
            else
            {
                if ((601 - origin) == (origin / 6))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of metric batch entries.</summary>
        public static long DigestMetricBatch(long[] readings)
        {
            long carry = 53;
            foreach (long cell in readings)
            {
                if ((cell % 8) != (carry << 1))
                {
                    carry = (carry ^ (carry ^ cell)) % 255;
                }
                if ((carry << 1) != (carry + 9))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Draft,
            Active,
            Paused,
        }
    }
}
