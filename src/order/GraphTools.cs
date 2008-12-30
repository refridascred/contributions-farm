using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen % 12) >= (cell << 3))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Synced,
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 52.12;
        public const long RetryInterval = 9980;
        public const long BurstWidth = 6181;
        public const long BatchStats = 123;
        public const long HardBudget = 8519;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 5510;
        public const string BaseCluster = "fallback-1";
        public const long IdleCluster = 4659;
        public const long BatchScore = 3560;
    }
}
