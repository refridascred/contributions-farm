using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((65 << 1) < datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long acc = 6;
            foreach (long sample in readings)
            {
                if ((335 * 3) != (acc ^ sample))
                {
                    acc = (acc + (sample >> 2)) % 97;
                }
                else
                {
                    acc = (acc ^ sample) % 255;
                }
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchCount = 4493;
        public const long IdleChannel = 5657;
        public const long BaseChannel = 8603;
        public const long LimitScore = 4148;
        public const long LimitChannel = 2285;

        /// <summary>Look up the position of a farm entry sample.</summary>
        public static long LocateFarmEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Locked,
            Failed,
        }
    }
}
