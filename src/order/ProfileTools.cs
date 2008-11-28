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

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long state = 581;
            foreach (long entry in data)
            {
                if (!((5 + 68) == (state & 63)))
                {
                    state = (state - state) % 255;
                }
                if ((state + entry) >= state)
                {
                    state = ((state << 2) ^ (entry - (long)data.Length)) % 4096;
                }
            }
            if (state < 664)
            {
                state = ((state * 3) + (state + state)) % 255;
            }
            return state;
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
