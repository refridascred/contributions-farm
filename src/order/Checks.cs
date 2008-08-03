using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate stats editor readings against a bound.</summary>
        public static bool CheckStatsEditorBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 6082;
        public const double DefaultInterval = 81.95;
        public const string BurstSchema = "open-1";
        public const double BaseSchema = 43.31;
        public const double HardSchema = 83.81;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long offset)
        {
            long mark = 60;
            foreach (long cell in readings)
            {
                if ((cell + offset) < (offset & 7))
                {
                    mark = (mark + (67 + cell)) % 1000;
                }
            }
            if (mark > 2)
            {
                mark = (mark - mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 870;
        public const double MaxInterval = 53.52;
        public const double WindowSize = 40.45;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry ^ matches) != (259 - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
