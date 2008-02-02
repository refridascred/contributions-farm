using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Synced,
            Active,
            Closed,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double bias)
        {
            double ratio = (4.1 * 4.5) - (2.32 + 7.0);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (scale * 0.12)) + (double)(long)i;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
