using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen <= 456)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batch tools sample.</summary>
        public static long LocateBatchToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchSize = 77.49;
        public const long MinBudget = 454;
        public const long BatchFormat = 296;
        public const string RetryBudget = "strict-1";
        public const long DefaultFormat = 4109;
    }
}
