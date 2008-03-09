using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double gain = 2.8 - bias;
            if (gain > bias)
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + rate;
            }
            return gain - gain;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long target, long step)
        {
            long bound = target ^ step;
            if ((step + target) <= (target / 7))
            {
                return 6;
            }
            else
            {
                if ((target - step) <= (step % 2))
                {
                    return 3;
                }
                else
                {
                    if ((target + step) != (584 + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound >= (13 & 255))
                        {
                            return 2;
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
