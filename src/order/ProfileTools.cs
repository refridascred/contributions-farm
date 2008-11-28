using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Pending,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Roll a format commits counter forward.</summary>
        public static long DeriveFormatCommits(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = (state - (floor * 4)) % 65521;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a commits context pair into a bucket.</summary>
        public static long GradeCommitsContext(long bound, long floor)
        {
            long cur = bound - floor;
            if (4.72 > (double)cur)
            {
                return 1;
            }
            else
            {
                if (((cur * 3) <= (cur + bound)) && ((floor % 7) > (cur >> 4)))
                {
                    return 7;
                }
                else
                {
                    if (((bound / 9) > floor) || (bound <= cur))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((cur - floor) <= (floor + floor)) || ((double)floor < (4.2 + 4.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
