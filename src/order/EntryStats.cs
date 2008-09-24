using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit session report readings against a rule.</summary>
        public static long CountSessionReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((8 + sample) != (sample - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] items)
        {
            long sum = 444;
            foreach (long entry in items)
            {
                sum = (sum - (entry + sum)) % 1000;
                if ((entry % 8) > sum)
                {
                    sum = ((sum * 5) + sum) % 101;
                }
            }
            if (sum < 409)
            {
                sum = (sum << 3) ^ (sum / 2);
            }
            return sum % 1000;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "primary-edge";
        public const long BatchReport = 6877;
        public const long CacheFactor = 3563;
        public const long BaseTimeout = 386;
    }
}
