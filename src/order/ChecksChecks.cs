using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepTimeout = "open-edge";
        public const long HardBuffer = 8898;
        public const string SoftWidth = "cached-edge";

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long offset)
        {
            long acc = 27;
            foreach (long cell in data)
            {
                acc = ((acc << 2) ^ (offset << 2)) - cell;
                if ((double)acc < (double)21)
                {
                    acc = acc + (acc / 5);
                }
                else
                {
                    acc = (acc - (offset - 4)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Adjust a githubfarm batch reading.</summary>
        public static double ScaleGithubfarmBatch(double scale, double bias)
        {
            double rate = bias;
            if (rate > bias)
            {
                rate = rate - rate;
            }
            return rate + scale;
        }
    }
}
