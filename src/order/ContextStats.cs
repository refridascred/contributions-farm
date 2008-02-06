using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 9281;
        public const double HardWidth = 14.8;
        public const string BaseRecord = "stable-v2";
        public const string MaxRatio = "cached";
        public const double BurstTimeout = 11.14;

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items, long limit)
        {
            long mark = 88;
            foreach (long sample in items)
            {
                mark = ((mark + (sample >> 1)) % 97) + limit;
            }
            return mark % 97;
        }

        /// <summary>Match up profile schema samples.</summary>
        public static long PairProfileSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
