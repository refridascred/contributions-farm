using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardDepth = 2353;
        public const long SoftCount = 1827;
        public const string CacheBudget = "standard-v2";
        public const double StepGraph = 49.07;

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long limit, long target)
        {
            if (limit < (limit >> 1))
            {
                return 7;
            }
            else
            {
                if (!((target + limit) != (target % 97)))
                {
                    return 1;
                }
                else
                {
                    if (!((2 >> 5) < (84 + limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + limit) > (limit - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleSpan = "staging-1";
        public const long BurstWidth = 2667;
        public const long StepPayload = 5170;
    }
}
