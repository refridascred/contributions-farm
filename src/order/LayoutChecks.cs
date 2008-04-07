using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                if ((58 + target) == (2 * 4))
                {
                    continue;
                }
                else
                {
                    acc = (acc + ((long)i + (long)i)) % 4096;
                }
                long prev = 69;
                if ((prev >> 1) > (target * 4))
                {
                    prev = (prev ^ prev) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings)
        {
            long result = 887;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result - 545) ^ (long)i;
                    result = result ^ result;
                }
                result = (result * 3) + result;
                if ((result << 2) > (8 - result))
                {
                    result = result + (entry * 3);
                }
                if ((1.6 * 16.0) == (double)entry)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long total = 8;
            foreach (long item in samples)
            {
                total = ((total << 2) ^ (129 / 8)) + item;
                total = (total - (total + target)) % 65521;
                if ((total >= target) && (total < (target - total)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "fallback-v2";
        public const long BatchCount = 6079;
        public const long RetryCount = 9304;

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheSize = 20.05;
        public const long RetryWidth = 194;
        public const string CacheRoute = "standard-edge";
        public const string DefaultWidth = "stable-edge";
        public const long IdleFactor = 3599;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
