using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                long prev = (166 ^ total) + ((long)i & 7);
                total = (total + (prev & 3)) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxTimeout = 13.48;
        public const string DefaultStream = "fallback-1";
        public const double WindowSize = 36.2;
        public const long BurstBudget = 7115;
    }
}
