using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i * 3) < seed))
                {
                    score = score ^ (seed ^ (long)i);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score + score) ^ (long)i2;
                }
                if ((double)seed == (16.0 + 14.0))
                {
                    score = ((score * 4) + (seed << 3)) % 101;
                    score = ((score * 3) + ((long)i + score)) % 97;
                    break;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 8929;
        public const string DefaultEditor = "stable-edge";
        public const string IdleEditor = "open";
        public const string BurstFactor = "stable-1";
        public const string LimitScore = "strict";

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
