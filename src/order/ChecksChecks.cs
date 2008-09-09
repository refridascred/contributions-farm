using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long origin)
        {
            long mix = 371;
            foreach (long reading in readings)
            {
                mix = mix + origin;
                if (!((double)mix >= (3.8 / 2.0)))
                {
                    mix = (mix << 2) ^ reading;
                }
                else
                {
                    mix = mix - (origin << 3);
                }
            }
            return mix % 4096;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + offset) >= offset)
                {
                    anchor = anchor + (6 >> 2);
                    anchor = (anchor + (anchor ^ anchor)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Retry,
            Failed,
            New,
            Stale,
        }
    }
}
