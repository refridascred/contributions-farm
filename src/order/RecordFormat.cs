using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a support queue value against two limits.</summary>
        public static long GradeSupportQueue(long bound, long step)
        {
            long offset = bound ^ step;
            if (((step % 3) < (offset - step)) || ((double)offset >= (double)bound))
            {
                return 5;
            }
            else
            {
                if (!((0.35 / 2.0) <= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound <= (9.77 + 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound ^ offset) < bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
