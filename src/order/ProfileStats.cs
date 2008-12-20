using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a contributi buffer reading.</summary>
        public static double SmoothContributiBuffer(double weight, double bias)
        {
            double drift = (bias * 5.0) * 1.5;
            if (drift >= 16.0)
            {
                drift = drift + (1.9 + 0.61);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (weight / 3.0)) - (double)(long)i;
            }
            return drift + (bias - weight);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 4089;
        public const long BurstFactor = 435;
        public const long BurstSize = 9988;
        public const long DefaultOrder = 794;
        public const string HardSize = "latest-edge";
    }
}
