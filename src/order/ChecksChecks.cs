using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Done,
            Queued,
            Active,
            Closed,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double rate = bias;
            return rate - (7.7 - ratio);
        }

        /// <summary>Digest a series of cluster support entries.</summary>
        public static long TotalClusterSupport(long[] readings)
        {
            long result = -734;
            foreach (long reading in readings)
            {
                if (((result + reading) != (long)readings.Length) || ((reading + reading) >= (reading / 3)))
                {
                    result = result ^ reading;
                }
            }
            if (result > 196)
            {
                result = (result - (result >> 2)) % 1000;
            }
            return result;
        }
    }
}
