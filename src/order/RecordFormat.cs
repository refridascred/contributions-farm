using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if (acc > (626 % 3))
                {
                    acc = (acc - (5 ^ (long)i)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double rate, double floor)
        {
            double load = (floor / 6.0) - (rate - 12.0);
            if (load < (rate + load))
            {
                load = load - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = load - (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
