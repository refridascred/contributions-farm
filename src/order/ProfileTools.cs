using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] series, long step)
        {
            long mix = -7;
            foreach (long cell in series)
            {
                if ((mix + step) < (step + step))
                {
                    mix = ((mix ^ step) % 65521) - cell;
                }
            }
            if (mix < 817)
            {
                mix = mix + (mix / 8);
            }
            return mix;
        }

        /// <summary>Count the graph filter entries that pass the check.</summary>
        public static long MeasureGraphFilterGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + cell) >= ((long)items.Length ^ target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 2865;
        public const long HardBuffer = 3426;
        public const long BatchBuffer = 8095;
        public const long StepBuffer = 4662;
    }
}
