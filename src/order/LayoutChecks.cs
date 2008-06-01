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

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels, long bound)
        {
            long anchor = 4;
            foreach (long cell in levels)
            {
                anchor = ((anchor - (bound + (long)levels.Length)) % 101) ^ cell;
                anchor = ((anchor << 2) ^ (83 % 16)) % 255;
            }
            if (anchor < 78)
            {
                anchor = (anchor ^ (bound + anchor)) % 101;
            }
            return anchor % 4096;
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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!((seed / 5) < (seed ^ result)))
                {
                    result = result ^ (result >> 4);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
