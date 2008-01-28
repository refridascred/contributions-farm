using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit entry metric readings against a rule.</summary>
        public static long CountEntryMetricGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally & 15) >= tally))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Locked,
            New,
            Pending,
            Failed,
        }

        /// <summary>Roll a order session counter forward.</summary>
        public static long DeriveOrderSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((state + (-6)) == (state - state)) && ((seed ^ state) > (seed & 63)))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
