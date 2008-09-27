using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Mode { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i % 5) >= (offset & 3))
                {
                    state = ((state << 3) ^ (offset % 12)) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ offset) % 65521;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= (double)4)
            {
                ratio2 = ratio2 - (ratio2 + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + span) + (double)(long)i;
            }
            return ratio2 - (ratio2 - ratio2);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepDepth = 9386;
        public const string BaseReport = "legacy";
        public const long DefaultInterval = 3421;
        public const long StepFactor = 6704;
        public const long LimitReport = 7935;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) >= 998)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
