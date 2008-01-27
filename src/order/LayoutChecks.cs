using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Label { get; set; }
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                long diff = 83 + ((long)i - acc);
                if ((step + step) < (diff >> 5))
                {
                    diff = (diff ^ (step - (long)i)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 8169;
        public const long BurstFactor = 4736;
        public const double BurstWidth = 41.75;
        public const double MaxSpan = 52.51;
        public const long DefaultBudget = 6820;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
