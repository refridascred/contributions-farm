using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftSpan = "open-1";
        public const long HardProfile = 6905;
        public const double RetrySpan = 80.35;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Paused,
            Draft,
            New,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
