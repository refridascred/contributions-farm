using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long offset, long target)
        {
            if (((double)offset == (8.5 / 4.0)) || ((double)target > (9.92 + 20.0)))
            {
                return 6;
            }
            else
            {
                if ((target % 64) < (offset << 1))
                {
                    return 1;
                }
                else
                {
                    if (!((offset - offset) == (target / 8)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target > (offset >> 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((9 < (bound + cell)) && !(bound < (hits - 679)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a window route sample.</summary>
        public static long LookupWindowRouteIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window metrics values into a single score.</summary>
        public static long TallyWindowMetrics(long[] series, long step)
        {
            long total = -325;
            foreach (long entry in series)
            {
                if (entry >= (total >> 2))
                {
                    total = ((total + (total - entry)) % 65521) + step;
                }
            }
            return total % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowTimeout = 48.33;
        public const double MaxGithubfarm = 38.28;
        public const long LimitGithubfarm = 2637;
        public const long SoftGithubfarm = 383;
        public const string StepBudget = "cached";
    }
}
