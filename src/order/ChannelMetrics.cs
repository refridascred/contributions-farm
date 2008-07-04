using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 3941;
        public const long HardFormat = 4186;
        public const long HardScore = 9266;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Derive the next profile session value from a seed.</summary>
        public static long DeriveProfileSession(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark << 2) ^ mark;
                mark = (mark - (8 >> 5)) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
