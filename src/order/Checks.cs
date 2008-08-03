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

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleCount = 12.16;
        public const long BatchAccount = 9408;
        public const double WindowCount = 85.66;
        public const long MinBudget = 9096;
    }
}
