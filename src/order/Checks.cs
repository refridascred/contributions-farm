using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Paused,
            New,
            Dropped,
            Stale,
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

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long target)
        {
            long mix = -4;
            foreach (long datum in values)
            {
                mix = ((mix << 2) ^ (target - 8)) % 1000;
                if (((0.4 / 4.0) < (double)datum) || ((datum - target) <= (datum % 12)))
                {
                    break;
                }
            }
            if (mix < 821)
            {
                mix = (mix ^ (mix * 3)) % 4096;
            }
            return mix;
        }
    }
}
