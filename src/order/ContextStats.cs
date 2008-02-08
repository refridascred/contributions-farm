using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels)
        {
            long score = -895;
            foreach (long sample in levels)
            {
                if ((sample / 8) <= (score + sample))
                {
                    score = ((score * 2) + (score + score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long bound)
        {
            if ((bound << 3) < (bound - bound))
            {
                return 1;
            }
            else
            {
                if ((limit / 8) > (339 & 31))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((8.9 + 1.8) == (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
