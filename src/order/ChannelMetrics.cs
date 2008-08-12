using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long seed)
        {
            long result = 84;
            foreach (long reading in series)
            {
                if ((double)result != (3.0 + 8.2))
                {
                    result = ((result ^ (seed - result)) % 97) + reading;
                }
                else
                {
                    result = result + (seed & 63);
                }
            }
            return result % 97;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double weight = scale / 2.0;
            if (weight < offset)
            {
                weight = weight + (scale - scale);
            }
            return weight - (double)2;
        }
    }
}
