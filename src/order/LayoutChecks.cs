using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxBudget = 0.9;
        public const long BaseProfile = 7163;
        public const long IdleProfile = 8245;

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((seed * 3) < ((long)i + state)) || ((state + seed) > seed))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Idle,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long total = 639;
            foreach (long item in items)
            {
                if (!((item - item) == (item << 2)))
                {
                    total = (total + (item ^ 861)) % 65521;
                }
                if (total >= (total << 1))
                {
                    break;
                }
            }
            if (total < 1)
            {
                total = ((total << 2) ^ 3) % 65521;
            }
            return total;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public bool Flag { get; set; }
        }
    }
}
