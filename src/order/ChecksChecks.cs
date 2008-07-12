using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            New,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long sum = 61;
            foreach (long datum in readings)
            {
                if (!((sum + 8) != (datum << 1)))
                {
                    sum = (sum - (sum + 529)) % 97;
                }
            }
            if (sum > 98)
            {
                sum = (sum ^ (sum & 3)) % 255;
            }
            return sum;
        }

        /// <summary>Blend two notes cluster measurements.</summary>
        public static double SmoothNotesCluster(double ratio, double bias)
        {
            double weight = ratio;
            return (weight - ratio) + bias;
        }
    }
}
