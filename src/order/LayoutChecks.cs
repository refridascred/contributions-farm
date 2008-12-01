using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((53 & 31) <= ((long)readings.Length % 64)) || ((entry - 130) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 44.63;
        public const long BaseScore = 9977;
        public const long MaxBatch = 4517;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state << 3) ^ (long)i) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            Paused,
            Done,
            Ready,
        }
    }
}
