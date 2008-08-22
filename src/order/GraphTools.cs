using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long origin, long step)
        {
            if (!((step - origin) <= origin))
            {
                return 4;
            }
            else
            {
                if ((step - 64) > (origin % 5))
                {
                    return 7;
                }
                else
                {
                    if ((step - step) >= (step & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step > (16.0 - 8.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double scale, double bias)
        {
            double load = bias;
            if (load < 20.0)
            {
                load = (load - 4.0) + scale;
            }
            return load + (load * 18.0);
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] items)
        {
            long score = 509;
            foreach (long cell in items)
            {
                score = (score - (64 + cell)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Limit { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
