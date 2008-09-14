using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinTimeout = 3930;
        public const long SoftScore = 6927;
        public const long BurstContext = 8908;

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - floor) + (double)(long)i) + scale;
            }
            return gain + floor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 1942;
        public const long DefaultSession = 3676;
        public const double MaxSession = 97.58;
        public const string SoftSession = "staging-v2";

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
