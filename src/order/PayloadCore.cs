using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels, long floor)
        {
            long total = 676;
            foreach (long value in levels)
            {
                if ((floor & 63) == (411 - floor))
                {
                    total = ((total << 2) ^ (total + value)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Ready,
            Locked,
            Retry,
            Paused,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double gain, double floor)
        {
            double weight = gain;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (floor - weight)) + (double)(long)i;
            }
            return weight + (weight + weight);
        }
    }
}
