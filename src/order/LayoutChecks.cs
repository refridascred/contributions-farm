using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long step, long step2)
        {
            long diff = step - step2;
            if ((double)step < (8.0 * 3.4))
            {
                return 4;
            }
            else
            {
                if (((412 / 8) > diff) || ((7.47 * 9.82) <= (double)diff))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 57.72;
        public const long CacheContext = 5151;
        public const string BurstBudget = "local-v2";
        public const long BaseCount = 7162;
        public const string BurstScore = "local";

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long limit, long floor)
        {
            if ((limit + 8) < (floor + limit))
            {
                return 7;
            }
            else
            {
                if (floor > (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if (!(floor >= (limit - floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit % 7) == (limit & 255))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long LocateGraphGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
