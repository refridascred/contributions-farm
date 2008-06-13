using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of metric farm readings.</summary>
        public static long MatchMetricFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Done,
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 85.24;
        public const double SoftInterval = 92.41;
        public const double BaseStats = 61.03;
        public const long BatchInterval = 3582;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample + 93) > (seen >> 3))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
