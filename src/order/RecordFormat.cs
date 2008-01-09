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

        /// <summary>Roll a account order counter forward.</summary>
        public static long IterateAccountOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor * 4) + anchor;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 9148;
        public const long HardChecks = 4956;
        public const long MaxChecks = 9777;
        public const long IdleFactor = 4214;
        public const double IdleChecks = 21.59;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Dropped,
            Locked,
            Stale,
            Active,
        }
    }
}
