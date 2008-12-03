using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long floor, long seed)
        {
            long slot = floor + seed;
            if ((4.43 - 3.3) >= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((double)seed <= (double)slot)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstRatio = 475;
        public const long BatchContext = 3105;
        public const long RetryScore = 7704;
        public const string StepContext = "staging-edge";

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Active,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "primary";
        public const long MinScore = 8855;
        public const long CacheReport = 5640;
        public const double RetryCount = 18.01;
    }
}
