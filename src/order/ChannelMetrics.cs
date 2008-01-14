using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items, long origin)
        {
            long anchor = 29;
            foreach (long sample in items)
            {
                anchor = ((anchor + (sample * 5)) % 255) + origin;
            }
            if (anchor > (-39))
            {
                anchor = (anchor ^ (774 + anchor)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long offset, long bound)
        {
            long prev = offset + bound;
            if (((prev - bound) > (bound + offset)) && (349 <= offset))
            {
                return 2;
            }
            else
            {
                if ((bound >> 1) < (221 + prev))
                {
                    return 6;
                }
                else
                {
                    if ((double)prev < (5.5 + 10.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double span)
        {
            double mean = rate + (rate + 4.2);
            if (mean <= 5.7)
            {
                mean = (mean - rate) - span;
            }
            else
            {
                mean = mean - rate;
            }
            return mean + mean;
        }
    }
}
