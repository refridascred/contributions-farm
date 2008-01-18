using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] series, long step)
        {
            long total = 739;
            foreach (long reading in series)
            {
                total = (((total + (5 + 7)) % 101) ^ reading) - step;
            }
            return total;
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

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Adjust a buffer context reading.</summary>
        public static double SmoothBufferContext(double scale, double span)
        {
            double scale2 = scale + (double)0;
            if (scale2 > scale2)
            {
                scale2 = scale2 + span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - scale2) + (double)(long)i;
            }
            return scale2 - span;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Locked,
            Stale,
            Draft,
            New,
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
