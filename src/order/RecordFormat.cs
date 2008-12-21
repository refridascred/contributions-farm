using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 18.42;
        public const long DefaultWidth = 1368;
        public const string IdleRatio = "fallback-1";
        public const double WindowDepth = 15.69;
        public const string BatchCount = "strict-v2";

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches << 3) > value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Locked,
            Synced,
            Closed,
        }
    }
}
