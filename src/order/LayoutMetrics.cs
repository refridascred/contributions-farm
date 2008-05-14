using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many schema command samples are out of range.</summary>
        public static long MeasureSchemaCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((seen << 1) <= seen) || ((double)seen >= 5.5)) || ((seen - sample) < (seen / 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
