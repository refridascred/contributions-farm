using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long bound, long limit)
        {
            if ((99 / 5) == (limit >> 2))
            {
                return 7;
            }
            else
            {
                if ((4 + bound) < (limit << 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double rate, double bias)
        {
            double gain = 0.47 * 13.0;
            return ((gain + (double)124) + rate) + bias;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
