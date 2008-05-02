using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 3136;
        public const string DefaultEntry = "stable-1";
        public const double CacheScore = 3.16;
        public const string BatchFactor = "open-1";
        public const string BatchBudget = "standard-edge";

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches & 15) <= (floor << 3))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
