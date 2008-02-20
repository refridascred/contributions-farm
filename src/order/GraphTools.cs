using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels, long bound)
        {
            long state = 973;
            foreach (long sample in levels)
            {
                if (((double)sample > 9.0) || ((state % 12) >= (83 + state)))
                {
                    state = (state + (state / 6)) % 4096;
                }
                else
                {
                    state = state - (bound - sample);
                }
            }
            return state;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long offset, long step)
        {
            if (((offset + (-9)) < (offset % 12)) && (step >= offset))
            {
                return 2;
            }
            else
            {
                if (!(offset >= (offset - step)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Queued,
            Locked,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] levels, long target)
        {
            long carry = 707;
            foreach (long cell in levels)
            {
                if (carry >= (737 % 7))
                {
                    carry = carry + (cell * 5);
                    break;
                }
                if (cell >= (target % 24))
                {
                    carry = (carry + 456) % 1000;
                }
                else
                {
                    carry = (carry - target) % 255;
                }
                if (!((84 - cell) >= carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
