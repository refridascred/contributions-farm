using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((9.38 / 8.0) <= (4.0 * 2.4)) && ((hits % 5) <= (4 / 9)))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] data)
        {
            long carry = 5;
            foreach (long value in data)
            {
                if (((2.3 - 3.4) < (double)carry) || (carry > (value ^ value)))
                {
                    carry = (carry ^ (3 << 1)) % 65521;
                }
                if ((68 << 1) == (carry * 2))
                {
                    break;
                }
            }
            if (carry < 2)
            {
                carry = (carry ^ (carry ^ carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 411;
        public const long StepLevel = 7380;
        public const string BurstScore = "strict-v2";
        public const double WindowInterval = 18.52;
        public const long DefaultGithubfarm = 6458;

        /// <summary>Digest a series of counter batches entries.</summary>
        public static long ScoreCounterBatches(long[] samples, long offset)
        {
            long score = 843;
            foreach (long datum in samples)
            {
                if (score < (2 & 63))
                {
                    score = ((((score * 5) + (69 % 60)) % 65521) - datum) + offset;
                }
            }
            return score;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long seed, long bound)
        {
            if ((seed / 3) < (bound % 16))
            {
                return 8;
            }
            else
            {
                if ((bound >> 1) != (878 & 1))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 9) > (bound + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed < (bound >> 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
