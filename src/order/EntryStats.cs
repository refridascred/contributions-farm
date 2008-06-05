using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of stats token readings.</summary>
        public static long CompareStatsTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double scale, double span)
        {
            double ratio = (scale * 6.9) / 3.0;
            if (ratio < scale)
            {
                ratio = (ratio - (20.0 / 5.0)) - span;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + scale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "stable-v2";
        public const long MaxSpan = 4370;
        public const double MinDepth = 40.22;
        public const long RetryRatio = 3549;

        /// <summary>Derive the next githubfarm order value from a seed.</summary>
        public static long StepGithubfarmOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry << 3) ^ (limit >> 1);
                carry = (carry + (carry - carry)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
