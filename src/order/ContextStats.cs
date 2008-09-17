using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix + mix) % 65521;
                if (((double)mix > (9.3 / 3.0)) && ((double)mix < (double)floor))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell != (6.0 - 20.0))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBudget = 93.41;
        public const long DefaultRatio = 8846;
        public const long StepRatio = 7982;
        public const long BatchBuffer = 653;
        public const long BatchSpan = 4684;
    }
}
