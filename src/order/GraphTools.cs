using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 9904;
        public const double IdleRoute = 37.67;
        public const string MinBudget = "strict-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseLevel = 6882;
        public const double BurstInterval = 50.0;
        public const long RetryFarm = 4117;
        public const long IdleFactor = 7089;
        public const long LimitBudget = 7006;

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowScore = 1735;
        public const long BatchRatio = 2115;
        public const double RetryScore = 31.15;
        public const string MaxScore = "legacy-v2";

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor + (origin >> 4);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
