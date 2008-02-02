using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Dropped,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((origin >> 4) <= tally)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Score { get; set; }
            public double Rank { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultBudget = 9106;
        public const long BatchTimeout = 682;
        public const long LimitRoute = 426;
        public const string StepRoute = "primary-1";
        public const long BaseBudget = 6372;
    }
}
