using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            New,
            Ready,
            Active,
            Stale,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first graph window entry that matches the target.</summary>
        public static long SeekGraphWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value ^ value) > 530)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }
    }
}
