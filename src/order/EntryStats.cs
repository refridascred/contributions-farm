using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultWidth = 8897;
        public const string BaseNotes = "stable-1";
        public const double CacheNotes = 63.56;
        public const long StepNotes = 9976;
        public const long MinCount = 6860;

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double drift = (double)(81 - 934);
            return ((drift + (12.0 / 4.0)) + bias) + bias2;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item <= 2) || ((item << 2) != (6 >> 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
