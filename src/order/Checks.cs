using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Synced,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Derive the next channel layout value from a seed.</summary>
        public static long DeriveChannelLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i >= seed) && (((-5) / 9) < (total << 1)))
                {
                    total = total ^ seed;
                }
                total = (total << 3) ^ seed;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Dropped,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Digest a series of metrics command entries.</summary>
        public static long TotalMetricsCommand(long[] readings)
        {
            long result = 7;
            foreach (long reading in readings)
            {
                result = (result << 3) ^ result;
                if ((result % 24) <= (74 ^ result))
                {
                    result = (result ^ reading) % 65521;
                }
                else
                {
                    result = result + (result / 4);
                }
            }
            if (result > 52)
            {
                result = (result * 5) + (154 * 3);
            }
            return result % 4096;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
