using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 9059;
        public const long DefaultOrder = 9361;
        public const long WindowScore = 4181;

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 3829;
        public const long StepInterval = 2825;
        public const long StepWidth = 8026;
        public const long StepCount = 4210;

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                sum = (sum - (sum + sum)) - reading;
            }
            return sum % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinScore = 5361;
        public const long IdleChannel = 8191;
        public const long LimitChannel = 2989;
    }
}
