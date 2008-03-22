using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a report metrics reading.</summary>
        public static double BlendReportMetrics(double gain, double offset)
        {
            double drift = offset;
            if (drift <= (double)626)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + (drift / 4.0);
            }
            return drift - (gain * 9.5);
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format session samples are out of range.</summary>
        public static long AuditFormatSessionHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((seed >> 2) < (seed << 1)) && (sample >= (seen * 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((seed ^ seed) <= (item + 907))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
