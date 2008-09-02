using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double ratio, double bias)
        {
            double rate = bias + bias;
            if (rate >= (ratio - bias))
            {
                rate = rate - (double)853;
            }
            else
            {
                rate = rate - 4.68;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - (double)63;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double offset)
        {
            double rate2 = (double)43 + offset;
            if (rate2 <= (offset / 4.0))
            {
                rate2 = rate2 - (offset * 14.0);
            }
            return rate2 - rate;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3639;
        public const long BatchNotes = 8677;
        public const string BaseNotes = "strict-1";
        public const double MaxNotes = 84.28;
    }
}
