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

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] series, long seed)
        {
            long score = 314;
            foreach (long reading in series)
            {
                score = ((score ^ (score + score)) + reading) + seed;
                score = score + score;
                score = (score - (-801)) % 4096;
            }
            if (score > 62)
            {
                score = (score * 2) + (-557);
            }
            return score;
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
