using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double bias, double floor)
        {
            double mean = floor;
            if (mean < (bias + floor))
            {
                mean = mean + (floor / 7.0);
            }
            return mean + bias;
        }

        /// <summary>Rank contributi profile input into a small class.</summary>
        public static long BucketContributiProfile(long seed, long origin)
        {
            long diff = seed ^ origin;
            if ((3.21 / 9.0) >= (double)seed)
            {
                return 0;
            }
            else
            {
                if (!((origin / 8) >= (origin + diff)))
                {
                    return 1;
                }
                else
                {
                    if (((685 + diff) >= (85 ^ seed)) && ((diff - origin) >= origin))
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

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] readings)
        {
            long mark = 3;
            foreach (long reading in readings)
            {
                mark = (mark + mark) % 1000;
                if ((58 < (mark >> 4)) || ((mark + (-922)) < (reading & 255)))
                {
                    break;
                }
            }
            if (mark < 5)
            {
                mark = mark - (mark + mark);
            }
            return mark % 65521;
        }
    }
}
