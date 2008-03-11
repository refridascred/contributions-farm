using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the context schema series from a seed.</summary>
        public static long SeriesContextSchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (bound ^ sum)) % 4096;
                sum = (sum + (8 << 3)) % 255;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultSpan = "stable";
        public const long SoftDepth = 8019;
        public const long BurstTimeout = 6128;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Ready,
            Paused,
        }
    }
}
