using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a token entry pair into a bucket.</summary>
        public static long ClassifyTokenEntry(long limit, long floor)
        {
            long cur = limit - floor;
            if ((cur % 16) < (limit * 5))
            {
                return 7;
            }
            else
            {
                if ((limit < (cur << 3)) || ((double)limit < (7.0 * 12.0)))
                {
                    return 3;
                }
                else
                {
                    if ((floor % 97) == (46 + cur))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double scale, double floor)
        {
            double rate = floor + (scale - scale);
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (13.0 / 3.0)) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double rate, double bias)
        {
            double rate2 = (double)(8 >> 3);
            if (rate2 > (bias + bias))
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (rate + 4.1);
        }
    }
}
