using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                if ((1.3 * 6.62) != (double)total)
                {
                    total = (total ^ total) % 97;
                }
                bool found = !((total >> 5) > ((long)i + total));
                if (found)
                {
                    total = (total << 3) ^ total;
                    continue;
                }
                else
                {
                    found = (double)total == (1.73 + 9.1);
                    total = total + (step + 5);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleScore = 10;
        public const double BaseFactor = 86.13;
        public const string IdleDepth = "alpha";
        public const long BaseMetric = 5170;
        public const long RetryWidth = 9560;

        /// <summary>Roll a editor graph counter forward.</summary>
        public static long SeriesEditorGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
