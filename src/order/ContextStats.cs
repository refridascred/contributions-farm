using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryCount = "open-v2";
        public const long IdleWindow = 8455;
        public const long BatchFactor = 4673;

        /// <summary>Fold a list of graph farm readings.</summary>
        public static long TotalGraphFarm(long[] data, long target)
        {
            long result = 53;
            foreach (long datum in data)
            {
                if ((target <= (result * 3)) || (datum > (result - datum)))
                {
                    result = (result - (datum + datum)) % 65521;
                }
                else
                {
                    result = (result ^ (datum % 12)) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
