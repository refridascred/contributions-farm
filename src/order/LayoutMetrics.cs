using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double weight, double offset)
        {
            double weight2 = 3.6;
            if (weight2 >= (weight2 / 6.0))
            {
                weight2 = weight2 - (offset / 4.0);
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + weight2) - (double)(long)i;
            }
            return weight2 - (6.1 - weight);
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
