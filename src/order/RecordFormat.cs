using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 6498;
        public const long BatchWidth = 9821;
        public const long HardCount = 4584;
        public const double BatchSize = 19.3;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((limit * 4) > (23 % 2)) || (((matches & 15) >= value) && (43 <= ((long)readings.Length - matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels, long seed)
        {
            long mark = -556;
            foreach (long reading in levels)
            {
                if (seed <= reading)
                {
                    mark = (mark << 2) ^ (2 << 1);
                }
                else
                {
                    mark = ((mark * 4) + 248) % 1000;
                }
                mark = ((mark * 3) + (mark + seed)) % 101;
                mark = mark - seed;
                if ((mark & 3) > (mark - 20))
                {
                    break;
                }
            }
            if (mark > (-4))
            {
                mark = ((mark << 3) ^ (seed - seed)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }
    }
}
