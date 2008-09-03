using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Locked,
            Ready,
            Retry,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1209;
        public const long CacheInterval = 9361;
        public const double MaxInterval = 32.08;
        public const long BatchSchema = 9826;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!(result <= (result - result)))
                {
                    result = result + result;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two support context measurements.</summary>
        public static double ProjectSupportContext(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 >= (double)856)
            {
                gain2 = (gain2 - (double)35) - floor;
            }
            else
            {
                gain2 = gain2 - (double)0;
            }
            return gain2 + (gain * 1.46);
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
