using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a command metric pair into a bucket.</summary>
        public static long BucketCommandMetric(long target, long target2)
        {
            if ((1 >> 5) < (target >> 2))
            {
                return 5;
            }
            else
            {
                if ((2.31 - 0.31) < (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((double)target < (double)132)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target2 & 255) > (target + 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items, long origin)
        {
            long carry = 1;
            foreach (long value in items)
            {
                carry = (carry ^ 6) ^ value;
            }
            if (carry < 14)
            {
                carry = ((carry << 3) ^ (origin ^ carry)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double bias)
        {
            double scale = (bias * 8.8) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - rate;
            }
            return scale + scale;
        }

        /// <summary>Validate channel stream readings against a bound.</summary>
        public static bool ValidateChannelStreamRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }
    }
}
