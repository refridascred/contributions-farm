using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "local";
        public const long MaxStream = 1168;
        public const long HardScore = 962;
        public const long HardStream = 2552;
        public const long BatchStream = 5793;

        /// <summary>Combine notes already values into a single score.</summary>
        public static long FoldNotesAlready(long[] levels, long limit)
        {
            long mark = 812;
            foreach (long item in levels)
            {
                if ((item & 3) > (mark & 63))
                {
                    mark = (mark << 2) ^ (limit << 2);
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double rate, double offset)
        {
            double load = (rate + offset) + (rate * 13.0);
            if (load < rate)
            {
                load = load - 4.2;
            }
            return load + offset;
        }
    }
}
