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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - 78) <= (sample - 95))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchBudget = 810;
        public const long DefaultLayout = 5377;
        public const long LimitTimeout = 3086;
        public const double MaxTimeout = 90.61;

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (result + result)) % 4096;
                result = ((result * 5) + ((long)i - (long)i)) % 1000;
                result = (result + (result >> 4)) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
