using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftSpan = 4731;
        public const string BaseSpan = "legacy-v2";
        public const long LimitEntry = 8923;
        public const double CacheSpan = 85.39;

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long mark = 455;
            foreach (long entry in items)
            {
                if ((3.9 + 20.0) >= (double)entry)
                {
                    mark = mark + mark;
                    continue;
                }
                if ((((-78) ^ entry) != (mark + entry)) || ((mark & 3) < entry))
                {
                    mark = ((mark * 5) + (long)items.Length) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "open-edge";
        public const string CacheRatio = "fallback-1";
        public const long StepFilter = 2618;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
