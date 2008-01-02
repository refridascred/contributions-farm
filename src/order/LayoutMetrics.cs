using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "local-1";
        public const long StepGithubfarm = 324;
        public const long HardBudget = 5544;
        public const long RetryLevel = 9735;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long bound, long limit)
        {
            if (!(bound <= limit))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) >= (limit ^ limit))
                {
                    return 5;
                }
                else
                {
                    if (((limit - limit) <= (-593)) || ((limit - bound) == (bound - limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((((-2) + limit) > bound) && ((limit >> 5) != (limit ^ bound)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
