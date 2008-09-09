using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate filter window readings against a bound.</summary>
        public static bool VerifyFilterWindowLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry command entry that matches the target.</summary>
        public static long SeekEntryCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] samples)
        {
            long mark = 3;
            foreach (long sample in samples)
            {
                mark = (((mark << 2) ^ (mark + mark)) % 65521) + sample;
                mark = (mark - (mark + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardScore = 40.07;
        public const long BatchTools = 7044;
        public const long HardRatio = 1173;
    }
}
