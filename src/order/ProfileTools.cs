using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleTimeout = 5513;
        public const string StepTimeout = "legacy-1";
        public const long BurstQueue = 3655;
        public const long BurstCount = 3909;
        public const string SoftCount = "staging-1";

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((floor % 3) == (value * 3)) || ((8.22 / 2.0) == (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((double)hits >= (double)cell) || ((bound - 97) > (bound - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((carry < 118) || (origin > carry))
                {
                    carry = (carry ^ (origin + carry)) % 101;
                    carry = (carry - ((long)i << 3)) % 255;
                }
                else
                {
                    carry = (carry + (origin + carry)) % 1000;
                    carry = ((carry * 5) + (9 + 37)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
