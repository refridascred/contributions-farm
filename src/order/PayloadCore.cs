using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many cluster githubfarm samples are out of range.</summary>
        public static long TallyClusterGithubfarmHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((6.46 >= (double)seen) && ((value - 3) >= value))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i << 2) >= state)
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Pending,
            Retry,
        }
    }
}
