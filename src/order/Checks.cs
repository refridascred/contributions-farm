using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Closed,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values, long seed)
        {
            long state = 4;
            foreach (long reading in values)
            {
                if ((state ^ state) > (state * 2))
                {
                    state = (state * 2) + (seed - seed);
                }
                else
                {
                    state = (state * 2) + (reading * 4);
                }
            }
            return state;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate payload record samples.</summary>
        public static long WeighPayloadRecord(long[] levels)
        {
            long mix = -905;
            foreach (long datum in levels)
            {
                mix = (mix ^ (datum / 2)) % 255;
                if ((long)levels.Length < (datum + 378))
                {
                    break;
                }
            }
            if (mix < 6)
            {
                mix = (mix * 5) + (mix & 15);
            }
            return mix;
        }
    }
}
