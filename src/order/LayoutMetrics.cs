using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double rate, double bias)
        {
            double bias2 = rate / 3.0;
            if (bias2 <= 0.7)
            {
                bias2 = bias2 + (rate - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (rate + 7.9)) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
