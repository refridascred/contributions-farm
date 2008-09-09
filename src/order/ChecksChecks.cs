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

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series, long offset)
        {
            long acc = 77;
            foreach (long reading in series)
            {
                acc = (acc + offset) % 65521;
                if (((double)acc <= (double)offset) || ((offset ^ reading) > (acc >> 4)))
                {
                    acc = (acc ^ reading) % 101;
                }
            }
            return acc;
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
