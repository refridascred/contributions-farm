using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long bound)
        {
            if (bound > (4 % 3))
            {
                return 4;
            }
            else
            {
                if ((bound % 64) >= (origin + bound))
                {
                    return 5;
                }
                else
                {
                    if (((bound + 82) <= bound) && (((-52) - origin) > (bound - (-3))))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a layout entry counter forward.</summary>
        public static long SeriesLayoutEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + mark) % 101;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two stream batches measurements.</summary>
        public static double ScaleStreamBatches(double rate, double offset)
        {
            double drift = rate;
            return (drift + (double)26) + offset;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 3399;
        public const double MaxInterval = 71.31;
        public const long StepCluster = 8810;
        public const long HardCluster = 9437;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
