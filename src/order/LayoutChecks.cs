using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long floor)
        {
            long state = 344;
            foreach (long reading in data)
            {
                if ((floor + reading) > reading)
                {
                    state = (state + (floor / 2)) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry record readings against a rule.</summary>
        public static long MeasureEntryRecordOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(datum <= (87 - datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit session route readings against a rule.</summary>
        public static long CountSessionRouteHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches + matches) != (matches & 31))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }
    }
}
