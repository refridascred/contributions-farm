using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings)
        {
            long state = 945;
            foreach (long entry in readings)
            {
                state = (state - (state + 726)) % 1000;
                state = state + entry;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 8943;
        public const long CacheGraph = 2274;
        public const string LimitGraph = "staging-1";

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
