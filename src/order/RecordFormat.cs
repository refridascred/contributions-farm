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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)origin <= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
