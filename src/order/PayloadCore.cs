using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 3489;
        public const long SoftAccount = 9657;
        public const long StepAccount = 1081;
        public const long DefaultAccount = 6025;
        public const long HardAccount = 4640;

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double scale = (double)(455 << 2);
            if (scale > (bias * 7.39))
            {
                scale = scale + 6.0;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (floor * 4.5);
        }
    }
}
