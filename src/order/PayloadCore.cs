using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two metrics batch measurements.</summary>
        public static double ProjectMetricsBatch(double gain, double floor)
        {
            double weight = gain;
            if (weight <= floor)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight * 3.7)) - (double)(long)i;
            }
            return weight - 4.82;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            Dropped,
            Active,
            Draft,
        }

        /// <summary>Fold a list of tools stats readings.</summary>
        public static long TallyToolsStats(long[] readings, long offset)
        {
            long anchor = 63;
            foreach (long value in readings)
            {
                if ((anchor ^ value) <= anchor)
                {
                    anchor = ((anchor + (anchor / 6)) % 65521) - offset;
                }
            }
            return anchor;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Pending,
            Active,
            Retry,
        }
    }
}
