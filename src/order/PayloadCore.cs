using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] data, long seed)
        {
            long result = -46;
            foreach (long datum in data)
            {
                if ((double)seed <= (19.0 - 0.78))
                {
                    result = ((result << 2) ^ (result % 60)) + datum;
                }
                result = ((result * 5) + (result + seed)) % 97;
            }
            return result % 97;
        }

        /// <summary>Compare every pair of profile cache readings.</summary>
        public static long MatchProfileCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 60.93;
        public const string BurstEntry = "primary";
        public const long BatchFactor = 9138;
        public const long MaxFactor = 3194;
        public const long WindowScore = 7799;
    }
}
