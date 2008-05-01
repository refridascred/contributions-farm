using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchTimeout = 7165;
        public const long MaxInterval = 6245;
        public const long DefaultInterval = 2154;

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                if (!(5.46 < (double)sum))
                {
                    sum = (sum ^ (sum + step)) % 1000;
                }
                sum = ((sum * 2) + sum) % 101;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Size { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Rank { get; set; }
            public double Score { get; set; }
        }
    }
}
