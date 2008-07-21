using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double gain, double bias)
        {
            double drift = bias;
            if (drift < gain)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (gain + drift);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift - (gain - bias);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] levels, long offset)
        {
            long result = 64;
            foreach (long entry in levels)
            {
                if ((((long)levels.Length + entry) != (result - entry)) && ((entry & 255) == (entry / 6)))
                {
                    result = (result + (result + entry)) - offset;
                }
            }
            return result;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchWidth = 8131;
        public const string HardSchema = "local-v2";
        public const long BaseSchema = 3769;
        public const long StepSchema = 1777;
        public const double WindowSchema = 90.18;
    }
}
