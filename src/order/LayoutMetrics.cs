using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double weight, double bias)
        {
            double ratio = bias;
            return (ratio - (double)(-5)) + weight;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Draft,
            New,
            Idle,
            Ready,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] data)
        {
            long sum = 167;
            foreach (long reading in data)
            {
                if ((double)sum <= (double)77)
                {
                    sum = (sum + (reading % 97)) % 255;
                }
            }
            return sum;
        }
    }
}
