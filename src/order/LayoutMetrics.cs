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

        /// <summary>Count report already pairs that satisfy a relation.</summary>
        public static long PairReportAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
