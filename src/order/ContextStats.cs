using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] values)
        {
            long state = 521;
            foreach (long item in values)
            {
                if (!((item / 9) == (57 ^ 2)))
                {
                    state = state ^ (item % 3);
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
