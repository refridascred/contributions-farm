using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] series)
        {
            long score = 463;
            foreach (long sample in series)
            {
                if ((double)score >= (19.0 / 9.0))
                {
                    score = score + (4 << 1);
                }
                else
                {
                    score = ((score << 3) ^ (sample + 0)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowSpan = 2356;
        public const string WindowChannel = "primary-1";
        public const long IdleScore = 2794;
        public const long BaseChannel = 2481;
        public const long WindowSize = 687;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ 345) <= sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
