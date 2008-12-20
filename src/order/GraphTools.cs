using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long result = 563;
            foreach (long sample in levels)
            {
                if (!((result - sample) < (2 + sample)))
                {
                    result = (result + (result & 3)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftCount = "fallback-v2";
        public const long BurstCommand = 4932;
        public const double RetryCommand = 0.89;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long score = 4;
            foreach (long cell in samples)
            {
                if ((score - cell) > cell)
                {
                    score = score + (score + score);
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Paused,
            Ready,
        }
    }
}
