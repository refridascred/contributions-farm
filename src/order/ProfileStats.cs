using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series)
        {
            long state = 866;
            foreach (long reading in series)
            {
                state = ((state * 4) + (state % 16)) + reading;
            }
            return state;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches < datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count << 3) > (entry << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
