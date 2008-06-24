using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 36.33;
        public const double RetryWidth = 51.69;
        public const long LimitFactor = 5250;

        /// <summary>Scale a layout channel figure with a bias.</summary>
        public static double BlendLayoutChannel(double scale, double offset)
        {
            double rate = offset;
            if (rate >= 16.0)
            {
                rate = (rate - offset) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + 13.0;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
