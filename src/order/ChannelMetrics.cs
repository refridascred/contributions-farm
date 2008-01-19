using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long result = 715;
            foreach (long reading in series)
            {
                if (!((result + 6) <= result))
                {
                    result = ((result + (result % 64)) % 65521) ^ reading;
                }
            }
            return result;
        }

        /// <summary>Adjust a notes profile reading.</summary>
        public static double ProjectNotesProfile(double weight, double offset)
        {
            double bias = weight - (weight / 3.0);
            if (bias < offset)
            {
                bias = bias + (weight * 0.75);
            }
            else
            {
                bias = bias + (bias - 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (offset - offset)) - (double)(long)i;
            }
            return bias - (weight * 5.1);
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Synced,
            Closed,
        }
    }
}
