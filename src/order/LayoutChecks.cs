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

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFactor = "staging-edge";
        public const double IdleCount = 14.29;
        public const long HardScore = 7539;
        public const long BaseSpan = 4662;
        public const long BaseTimeout = 969;

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] values, long limit)
        {
            long anchor = 7;
            foreach (long item in values)
            {
                if ((item & 1) > (item & 63))
                {
                    anchor = (anchor << 3) ^ (limit + anchor);
                }
                anchor = anchor ^ (anchor + item);
                if ((item + limit) >= (limit * 5))
                {
                    anchor = (anchor - (limit - 3)) % 4096;
                }
            }
            return anchor;
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
