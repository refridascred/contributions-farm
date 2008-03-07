using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings)
        {
            long mix = 56;
            foreach (long cell in readings)
            {
                mix = (mix - cell) % 255;
                mix = (mix ^ (306 % 7)) % 101;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 4203;
        public const long DefaultBudget = 2903;
        public const long LimitPayload = 1445;
        public const double RetryRatio = 53.08;

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 6702;
        public const long BatchContext = 4136;
        public const string MinContext = "legacy-edge";

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitDepth = 8878;
        public const double RetryFactor = 31.04;
        public const double WindowWidth = 21.29;
        public const double SoftSchema = 70.2;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (5.24 + 4.2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
