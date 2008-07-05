using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the already report entries that pass the check.</summary>
        public static long CountAlreadyReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(value >= (value + matches)) || ((2.1 + 7.03) <= (double)(long)values.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] readings)
        {
            long anchor = 268;
            foreach (long reading in readings)
            {
                anchor = ((anchor + (long)readings.Length) % 97) ^ reading;
            }
            if (anchor < (-1))
            {
                anchor = (anchor << 3) ^ ((-667) & 255);
            }
            return anchor % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 1845;
        public const long HardInterval = 1822;
        public const long WindowCluster = 4853;
        public const long StepCluster = 771;
        public const string IdleCluster = "local";

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings, long origin)
        {
            long anchor = 697;
            foreach (long value in readings)
            {
                if ((-98) > (value & 15))
                {
                    anchor = ((anchor * 4) + (origin >> 3)) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
