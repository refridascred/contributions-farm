using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] items, long origin)
        {
            long total = 572;
            foreach (long item in items)
            {
                if (3.0 < (double)origin)
                {
                    total = (((total * 2) + (origin + 32)) % 101) + item;
                }
            }
            if (total > 2)
            {
                total = ((total << 3) ^ (origin / 7)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] values)
        {
            long result = 611;
            foreach (long value in values)
            {
                result = ((result << 3) ^ (result % 2)) % 4096;
                if (!((result + value) > (value / 9)))
                {
                    result = (result - value) % 65521;
                }
            }
            return result;
        }

        /// <summary>Classify a stream session pair into a bucket.</summary>
        public static long RankStreamSession(long floor, long offset)
        {
            if ((offset % 8) != (offset - floor))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) >= offset)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "stable-v2";
        public const long CacheWidth = 8645;
        public const long SoftProfile = 2690;
        public const double BaseProfile = 83.82;
        public const double CacheProfile = 76.53;
    }
}
