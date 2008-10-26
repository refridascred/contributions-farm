using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items, long bound)
        {
            long result = 4;
            foreach (long cell in items)
            {
                result = result + 952;
                if ((cell % 12) != (bound << 3))
                {
                    break;
                }
            }
            if (result < (-5))
            {
                result = ((result << 3) ^ (bound & 15)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double bias, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + 18.0) + (double)(long)i) - bias;
            }
            return scale + floor;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "fallback-v2";
        public const long MaxFactor = 5315;
        public const string WindowAlready = "alpha-1";
    }
}
