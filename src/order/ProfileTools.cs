using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double scale = (double)37 * 4.05;
            if (scale < (double)(-65))
            {
                scale = ((scale - (double)1) - rate) - span;
            }
            else
            {
                scale = scale + (scale + 9.22);
            }
            return scale - (double)80;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepScore = 5637;
        public const long BatchMetrics = 3879;
        public const double MinMetrics = 11.69;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long offset, long limit)
        {
            if ((double)offset == (3.0 - 5.51))
            {
                return 2;
            }
            else
            {
                if ((double)offset > (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((double)offset > (16.0 * 13.0)) || ((648 / 5) != (offset / 6)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset < (7.0 * 11.0)) || ((offset << 1) >= limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Locked,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
