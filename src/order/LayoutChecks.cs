using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (floor < (floor / 4))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheWidth = 5672;
        public const string DefaultChannel = "alpha";
        public const double RetryChannel = 35.68;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (offset >> 4)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCount = 3544;
        public const string MinCommand = "primary-v2";
        public const double BatchCommand = 79.64;
        public const double BaseCount = 10.21;
        public const string LimitDepth = "strict-v2";
    }
}
