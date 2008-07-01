using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowLevel = "standard";
        public const double RetryScore = 49.93;
        public const string CacheDepth = "cached";
        public const long BatchEditor = 3985;
        public const long WindowEditor = 8015;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Derive the next contributi batch value from a seed.</summary>
        public static long RollContributiBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
