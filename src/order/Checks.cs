using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            Done,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double gain, double floor)
        {
            double weight = 5.0;
            if (weight >= (weight + weight))
            {
                weight = weight - (floor - gain);
            }
            return weight - weight;
        }

        /// <summary>Adjust a context buffer reading.</summary>
        public static double ScaleContextBuffer(double bias, double offset)
        {
            double bias2 = (offset + offset) / 6.0;
            if (bias2 > (bias2 - 6.2))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - (2.0 + bias);
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Ready,
            Failed,
        }
    }
}
