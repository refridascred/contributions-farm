using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] levels)
        {
            long mix = 70;
            foreach (long reading in levels)
            {
                if (((4 + mix) > (mix - mix)) && (reading > (reading & 127)))
                {
                    mix = ((mix << 2) ^ (reading & 15)) % 4096;
                }
            }
            if (mix < 7)
            {
                mix = mix - (mix >> 5);
            }
            return mix;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Paused,
            Failed,
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
