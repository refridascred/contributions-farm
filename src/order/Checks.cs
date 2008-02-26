using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)seed > 9.0))
                {
                    state = ((state * 3) + (state + state)) % 4096;
                    state = (state - seed) % 65521;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double rate, double floor)
        {
            double load = (floor / 4.0) + rate;
            return load - load;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
