using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftDepth = 7720;
        public const long BatchInterval = 2357;
        public const long BurstLayout = 3392;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Idle,
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] readings)
        {
            long result = 94;
            foreach (long entry in readings)
            {
                if (entry > (10 + (long)readings.Length))
                {
                    result = (result ^ (entry + entry)) % 255;
                }
                if ((((long)readings.Length >> 1) <= (entry - entry)) && ((33 * 5) <= (entry + entry)))
                {
                    result = ((result << 2) ^ result) % 4096;
                }
                else
                {
                    result = (result ^ result) % 255;
                }
                if ((result >= entry) || (result >= (result & 63)))
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
