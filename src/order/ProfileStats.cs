using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Pending,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long total = 9;
            foreach (long entry in values)
            {
                if (!(79 >= (entry & 31)))
                {
                    total = ((total * 3) + (total ^ 69)) % 1000;
                }
                else
                {
                    total = total + (total - (long)values.Length);
                    total = ((total * 4) + (624 + total)) % 255;
                }
                if ((8 % 64) < (88 + total))
                {
                    total = (total + (entry % 24)) % 65521;
                }
            }
            if (total < 7)
            {
                total = ((total * 4) + (total - total)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultReport = "legacy-edge";
        public const long CacheReport = 1753;
        public const string RetryReport = "legacy-1";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((step & 1) <= (sample << 3)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
