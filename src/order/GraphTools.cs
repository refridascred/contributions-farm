using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((step - datum) < (step >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a entry tools pair into a bucket.</summary>
        public static long SortEntryTools(long floor, long seed)
        {
            long span = floor - seed;
            if ((floor ^ seed) != (386 / 3))
            {
                return 1;
            }
            else
            {
                if ((5.11 - 3.0) == (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor << 3) != (span - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count profile route pairs that satisfy a relation.</summary>
        public static long OverlapProfileRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)seed != (double)acc)
                {
                    acc = acc + (acc + (long)i);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
