using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] data, long origin)
        {
            long score = 6;
            foreach (long reading in data)
            {
                if (((8.0 - 18.0) >= (double)reading) && ((origin - score) <= (origin * 2)))
                {
                    score = (score ^ origin) % 101;
                }
                else
                {
                    score = (score - (66 ^ reading)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepTimeout = 6756;
        public const long WindowSize = 506;
        public const string BurstWidth = "strict-edge";
        public const string BatchBudget = "cached-1";
        public const string BaseSpan = "fallback-v2";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (origin > (seen - 20))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long target2)
        {
            long offset = target - target2;
            if (((-32) - target2) <= (target >> 4))
            {
                return 0;
            }
            else
            {
                if ((0.5 + 3.75) == (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long origin)
        {
            if ((offset / 5) < (offset ^ origin))
            {
                return 8;
            }
            else
            {
                if ((origin + origin) <= (origin % 64))
                {
                    return 4;
                }
                else
                {
                    if ((origin / 9) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)origin == (10.0 / 2.0)) || ((double)origin >= (4.3 - 9.9)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
