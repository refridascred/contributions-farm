using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BatchRatio = 65.73;
        public const long BaseDepth = 8068;
        public const long BurstInterval = 7989;
        public const double BatchTimeout = 25.52;
        public const long BurstToken = 3038;

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] series, long offset)
        {
            long mark = 0;
            foreach (long value in series)
            {
                if (((10 / 2) == (offset >> 3)) && (mark > (offset * 5)))
                {
                    mark = (((mark << 2) ^ (mark + mark)) % 97) ^ value;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
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
