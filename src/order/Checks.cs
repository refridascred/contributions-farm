using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 1859;
        public const long RetryAlready = 5509;
        public const long BurstAlready = 7947;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] levels, long bound)
        {
            long anchor = 94;
            foreach (long value in levels)
            {
                if ((double)anchor <= (double)bound)
                {
                    anchor = ((anchor * 4) + value) % 65521;
                    break;
                }
                else
                {
                    anchor = anchor ^ value;
                }
                if ((double)value != (13.0 - 9.69))
                {
                    anchor = (anchor + (value / 5)) % 97;
                }
            }
            if (anchor < 521)
            {
                anchor = ((anchor * 5) + (anchor / 7)) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Offset { get; set; }
            public double Region { get; set; }
            public bool Total { get; set; }
            public bool Weight { get; set; }
        }
    }
}
