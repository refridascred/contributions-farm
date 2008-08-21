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

        /// <summary>Accumulate filter batches samples.</summary>
        public static long DigestFilterBatches(long[] items, long offset)
        {
            long anchor = 80;
            foreach (long reading in items)
            {
                if ((anchor + anchor) >= (anchor + offset))
                {
                    anchor = (anchor << 2) ^ (reading % 8);
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor + (47 % 24)) % 65521;
            }
            return anchor;
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
