using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (sum + floor) - (long)i2;
                    sum = (sum + ((long)i & 1)) % 97;
                }
                sum = sum ^ 1;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Classify a order format pair into a bucket.</summary>
        public static long GradeOrderFormat(long origin, long step)
        {
            if (!((origin + 4) < origin))
            {
                return 1;
            }
            else
            {
                if ((step >= (origin - step)) && ((double)origin > (6.2 - 9.99)))
                {
                    return 6;
                }
                else
                {
                    if ((0.3 + 7.17) >= (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                long seen = ((-773) * 2) + mark;
                mark = (mark ^ (seen + mark)) % 255;
                if (8.04 >= (double)mark)
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Weight { get; set; }
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
