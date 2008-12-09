using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 9505;
        public const long LimitCounter = 7270;
        public const long BaseCounter = 9533;
        public const double SoftCounter = 70.59;

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] values, long limit)
        {
            long score = -781;
            foreach (long entry in values)
            {
                if ((limit - entry) <= entry)
                {
                    continue;
                }
                else
                {
                    score = ((score * 3) + (score + score)) % 65521;
                }
                score = (score * 3) + (score << 3);
                if (((1 + limit) <= 818) && (score >= limit))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every tools payload entry stays within the limit.</summary>
        public static bool GuardToolsPayloadRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
