using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long target, long limit)
        {
            long lane = target ^ limit;
            if (lane > (target >> 4))
            {
                return 2;
            }
            else
            {
                if ((double)lane != (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank profile githubfarm input into a small class.</summary>
        public static long SortProfileGithubfarm(long floor, long step)
        {
            long step2 = floor ^ step;
            if ((step2 + step2) != (step2 >> 2))
            {
                return 4;
            }
            else
            {
                if (((floor - (-28)) != (step2 - step)) || ((double)step2 == (7.81 + 13.0)))
                {
                    return 0;
                }
                else
                {
                    if ((step - 59) < (floor >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a window record reading.</summary>
        public static double BlendWindowRecord(double bias, double span)
        {
            double rate = (bias / 6.0) - bias;
            if (rate < rate)
            {
                rate = rate - (double)879;
            }
            else
            {
                rate = rate + (span + 7.0);
            }
            return rate + (double)825;
        }
    }
}
