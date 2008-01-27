using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Retry,
            Draft,
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

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels, long step)
        {
            long total = 5;
            foreach (long datum in levels)
            {
                if ((step + datum) <= step)
                {
                    total = ((total * 4) + (datum + total)) % 4096;
                }
                else
                {
                    total = (total + (535 - datum)) % 1000;
                }
                if (datum <= ((-906) & 3))
                {
                    total = (total - (datum & 63)) % 97;
                }
            }
            return total;
        }
    }
}
