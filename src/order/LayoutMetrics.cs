using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum << 3) ^ step) % 255;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((matches % 7) > matches) && ((item + 476) >= (matches / 2)))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinScore = 9396;
        public const long StepBatches = 2533;
        public const string WindowBatches = "legacy-edge";
        public const long BaseBatches = 8903;
    }
}
