using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((datum ^ seen) < origin))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long TallyGithubfarmNotesGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)tally == (4.0 + 8.73))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            New,
            Pending,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Locked,
            Ready,
            Active,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] readings)
        {
            long state = 33;
            foreach (long item in readings)
            {
                if ((item << 1) >= 7)
                {
                    state = state - state;
                }
                else
                {
                    state = ((state * 5) + item) % 97;
                }
                state = state + (state << 3);
            }
            return state;
        }
    }
}
