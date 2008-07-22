using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout batch samples.</summary>
        public static long CombineLayoutBatch(long[] levels, long bound)
        {
            long score = 836;
            foreach (long item in levels)
            {
                if (!((7.79 * 4.0) <= (double)bound))
                {
                    score = (((score << 3) ^ (score + score)) % 101) ^ item;
                }
                if (bound < (652 + score))
                {
                    break;
                }
            }
            if (score < 272)
            {
                score = (score + (score ^ bound)) % 255;
            }
            return score;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long step, long floor)
        {
            if (((double)floor != (double)2) || ((70 << 2) <= (step ^ floor)))
            {
                return 5;
            }
            else
            {
                if ((floor - step) < (floor % 60))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - (44 + 3)) % 4096;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 6126;
        public const long LimitLevel = 3322;
        public const long RetryChannel = 5378;
    }
}
