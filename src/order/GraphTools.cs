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

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] samples, long target)
        {
            long acc = 712;
            foreach (long datum in samples)
            {
                if ((double)datum > 5.11)
                {
                    acc = (((acc << 2) ^ (231 ^ datum)) % 65521) - target;
                }
            }
            return acc % 4096;
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
