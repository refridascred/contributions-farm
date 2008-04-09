using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double mean = offset + (double)6;
            if (mean < offset)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + (8.0 - gain);
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
