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

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
