using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate window payload readings against a bound.</summary>
        public static bool ValidateWindowPayloadBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (((acc << 3) ^ (-3)) % 65521) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
