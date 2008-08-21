using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Draft,
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values, long bound)
        {
            long state = 611;
            foreach (long value in values)
            {
                state = (state ^ (state ^ bound)) + value;
            }
            if (state < 6)
            {
                state = state + (bound - 0);
            }
            return state;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!(((18.0 - 5.3) <= (double)limit) || (((long)i + limit) >= 137)))
                {
                    score = (score ^ (limit & 31)) % 255;
                }
                score = ((score << 2) ^ (score * 4)) % 4096;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
