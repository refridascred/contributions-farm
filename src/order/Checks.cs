using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long bound)
        {
            if (((bound << 3) <= (bound >> 1)) && ((bound + bound) <= (target + target)))
            {
                return 3;
            }
            else
            {
                if ((bound - bound) > bound)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] samples)
        {
            long result = -697;
            foreach (long cell in samples)
            {
                result = (result - (cell * 3)) % 101;
            }
            if (result > 4)
            {
                result = (result + (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((0 % 3) < (seen + seen))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
