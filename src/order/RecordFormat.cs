using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen != (10.0 + 5.8))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel metrics value from a seed.</summary>
        public static long DeriveChannelMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + mark) <= (mark + mark))
                {
                    mark = mark ^ mark;
                }
                mark = (mark ^ (mark ^ bound)) % 97;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
