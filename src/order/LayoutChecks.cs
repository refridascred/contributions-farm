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

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long bound, long bound2)
        {
            if ((bound2 - (-956)) >= (bound + bound2))
            {
                return 2;
            }
            else
            {
                if ((bound < (bound2 + bound)) && ((double)bound < (3.4 / 7.0)))
                {
                    return 0;
                }
                else
                {
                    if (bound <= (bound2 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((148 + (-486)) != (bound2 << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
