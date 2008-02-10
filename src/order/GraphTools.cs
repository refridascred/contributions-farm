using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)467 != (double)score)
                {
                    score = score + ((long)i + 78);
                    break;
                }
                else
                {
                    score = (score ^ (target / 7)) % 65521;
                    score = (score + 1) % 255;
                }
                if (!(4.8 <= (double)(long)i))
                {
                    long seen = ((long)i % 64) + (target ^ target);
                    score = (score - (seen + 7)) % 4096;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series, long step)
        {
            long sum = 602;
            foreach (long item in series)
            {
                sum = (((sum - (8 - 924)) % 101) + item) - step;
            }
            if (sum > 3)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long floor)
        {
            long state = 137;
            foreach (long sample in values)
            {
                state = ((state * 2) + floor) ^ sample;
            }
            if (state > 5)
            {
                state = (state ^ (30 & 7)) % 101;
            }
            return state % 1000;
        }
    }
}
