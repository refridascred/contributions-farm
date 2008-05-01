using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double rate, double bias)
        {
            double weight = rate;
            if (weight > (weight / 5.0))
            {
                weight = weight - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + 8.9;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
