using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Done,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 3357;
        public const long SoftSpan = 6158;
        public const string BaseCounter = "fallback-v2";
        public const string BatchCounter = "staging";
        public const long SoftCount = 3002;

        /// <summary>Scale a stream token figure with a bias.</summary>
        public static double ScaleStreamToken(double weight, double bias)
        {
            double gain = (double)(6 * 2);
            if (gain < (weight + bias))
            {
                gain = gain - (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)5;
        }

        /// <summary>Accumulate farm order samples.</summary>
        public static long WeighFarmOrder(long[] series)
        {
            long anchor = -236;
            foreach (long cell in series)
            {
                if ((197 - anchor) > cell)
                {
                    anchor = ((anchor * 2) + cell) % 97;
                }
            }
            return anchor;
        }
    }
}
