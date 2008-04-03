using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (349 >= (value % 10))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session graph entries.</summary>
        public static long FoldSessionGraph(long[] items, long origin)
        {
            long total = 7;
            foreach (long item in items)
            {
                total = ((total + (origin % 16)) % 65521) - item;
            }
            if (total > 65)
            {
                total = total ^ (origin + origin);
            }
            return total % 4096;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen <= (cell + floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
