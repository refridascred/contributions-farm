using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 2599;
        public const long LimitChecks = 3359;
        public const long IdleChecks = 3474;
        public const long DefaultChecks = 5122;

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] items, long origin)
        {
            long score = 307;
            foreach (long cell in items)
            {
                score = ((score + (long)items.Length) ^ cell) + origin;
            }
            return score;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long limit2)
        {
            if ((1.49 + 3.56) == (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit - limit2) < limit)
                {
                    return 3;
                }
                else
                {
                    if (84 > limit2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit2 % 10) < (limit2 & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
