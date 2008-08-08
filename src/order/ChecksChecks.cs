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

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long limit, long offset)
        {
            if (offset >= (offset << 2))
            {
                return 1;
            }
            else
            {
                if (((limit >> 5) > (offset + offset)) || ((offset - offset) >= offset))
                {
                    return 7;
                }
                else
                {
                    if ((offset % 2) != (offset / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
