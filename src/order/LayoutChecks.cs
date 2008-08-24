using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = ((state << 3) ^ (state << 2)) % 101;
                state = state - (6 ^ 237);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double ratio = (12.0 / 2.0) - gain;
            if (ratio > gain)
            {
                ratio = ratio + (ratio - floor);
            }
            return ratio - 6.9;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchBudget = 810;
        public const long DefaultLayout = 5377;
        public const long LimitTimeout = 3086;
        public const double MaxTimeout = 90.61;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Ready,
            Dropped,
            Locked,
        }
    }
}
