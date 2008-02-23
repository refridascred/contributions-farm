using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a route githubfarm figure with a bias.</summary>
        public static double ProjectRouteGithubfarm(double gain, double bias)
        {
            double bias2 = bias;
            return (bias2 - (double)88) + gain;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] series, long offset)
        {
            long state = 2;
            foreach (long datum in series)
            {
                state = (state + state) % 101;
                if ((long)series.Length < datum)
                {
                    state = state ^ offset;
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally - 96) < tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
