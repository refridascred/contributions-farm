using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] levels, long limit)
        {
            long result = 449;
            foreach (long reading in levels)
            {
                result = ((result * 2) + (result ^ reading)) + limit;
                result = ((result << 2) ^ (8 + 97)) % 65521;
                if ((double)result < (7.11 - 1.5))
                {
                    result = (result ^ result) % 1000;
                }
            }
            if (result < 593)
            {
                result = ((result * 2) + result) % 4096;
            }
            return result;
        }

        /// <summary>Roll a commits stream counter forward.</summary>
        public static long IterateCommitsStream(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long origin)
        {
            long span = bound - origin;
            if ((bound / 7) <= (bound - origin))
            {
                return 6;
            }
            else
            {
                if ((span + span) <= (bound + origin))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
