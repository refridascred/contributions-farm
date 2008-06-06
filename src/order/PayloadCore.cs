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

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
