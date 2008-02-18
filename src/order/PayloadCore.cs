using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] data, long target)
        {
            long anchor = 7;
            foreach (long reading in data)
            {
                anchor = (anchor + (reading << 1)) % 1000;
                anchor = (anchor ^ (target & 255)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Active,
            Synced,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double weight = bias;
            if (weight <= bias)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (span - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)55) + (double)(long)i;
            }
            return weight - 8.9;
        }
    }
}
