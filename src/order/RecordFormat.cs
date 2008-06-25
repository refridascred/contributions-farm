using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Queued,
            New,
            Stale,
            Retry,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor - (seed >> 2)) % 4096) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of filter context readings.</summary>
        public static long TallyFilterContext(long[] data)
        {
            long state = -2;
            foreach (long reading in data)
            {
                if ((reading ^ reading) >= ((long)data.Length >> 4))
                {
                    state = ((state * 5) + (reading / 4)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Done,
            Locked,
            Pending,
        }
    }
}
