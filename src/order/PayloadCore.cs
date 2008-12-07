using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (4.2 >= (double)datum)
                {
                    tally = (tally + 2) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Pending,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!(651 < state))
                {
                    state = ((state * 3) + (state >> 5)) % 1000;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double weight = span;
            if (weight > span)
            {
                weight = (weight - span) + ratio;
            }
            else
            {
                weight = weight - (span - weight);
            }
            return weight - span;
        }
    }
}
