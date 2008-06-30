using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen > (datum / 5)) || ((double)seen < 0.7))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long seed)
        {
            long delta = bound - seed;
            if (seed >= delta)
            {
                return 5;
            }
            else
            {
                if (seed > (delta - bound))
                {
                    return 1;
                }
                else
                {
                    if ((seed + 160) <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
