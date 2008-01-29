using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of counter channel readings.</summary>
        public static long WeighCounterChannel(long[] series)
        {
            long result = 9;
            foreach (long value in series)
            {
                result = (result * 3) + (value ^ 6);
            }
            return result;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 93.56;
        public const long BatchNotes = 8863;
        public const long BaseNotes = 6649;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Ready,
            Draft,
            Active,
            Retry,
        }
    }
}
