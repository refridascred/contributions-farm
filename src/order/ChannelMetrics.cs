using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long offset, long bound)
        {
            if (6 < bound)
            {
                return 2;
            }
            else
            {
                if ((bound >> 3) > bound)
                {
                    return 0;
                }
                else
                {
                    if (((2.91 * 14.0) == (double)offset) || ((bound << 1) != (offset - offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 1) < bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double gain, double bias)
        {
            double rate = gain;
            if (rate > bias)
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate - (8.99 - 3.0);
            }
            return rate - (1.0 / 2.0);
        }
    }
}
