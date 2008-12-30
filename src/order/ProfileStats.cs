using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double weight = (floor - 19.0) - (floor * 9.81);
            if (weight > weight)
            {
                weight = weight + (floor / 5.0);
            }
            else
            {
                weight = weight - (3.5 * 4.8);
            }
            return weight + gain;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings, long target)
        {
            long mark = 9;
            foreach (long datum in readings)
            {
                if ((mark % 60) <= datum)
                {
                    mark = (((mark * 2) + 1) % 1000) + target;
                }
                else
                {
                    mark = (mark - (822 / 4)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long limit, long floor)
        {
            long bound = limit - floor;
            if ((floor > (floor - floor)) || ((limit + limit) >= (bound >> 1)))
            {
                return 2;
            }
            else
            {
                if (((double)bound != (1.8 - 7.9)) || (floor <= limit))
                {
                    return 4;
                }
                else
                {
                    if ((floor >> 5) <= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
