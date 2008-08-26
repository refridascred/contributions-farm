using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context cache readings.</summary>
        public static long ScoreContextCache(long[] items, long seed)
        {
            long carry = 8;
            foreach (long sample in items)
            {
                if ((carry + carry) == (seed + 4))
                {
                    carry = (carry - seed) + sample;
                }
            }
            return carry;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleRatio = 7141;
        public const long MaxCounter = 4785;
        public const string RetryCounter = "open-v2";

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double span)
        {
            double weight = 8.3;
            return ((weight + (weight / 3.0)) + scale) + span;
        }
    }
}
