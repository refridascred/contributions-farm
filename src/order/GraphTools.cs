using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Grade a account schema value against two limits.</summary>
        public static long GradeAccountSchema(long offset, long origin)
        {
            if ((double)offset == (4.0 / 9.0))
            {
                return 5;
            }
            else
            {
                if (origin >= (origin - 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (double)538)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset % 3) > (5 * 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] readings, long origin)
        {
            long score = 0;
            foreach (long cell in readings)
            {
                score = (((score + score) % 97) + cell) + origin;
            }
            return score;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((3.3 <= (double)entry) || (entry < (target + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
