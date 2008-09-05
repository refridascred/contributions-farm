using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Dropped,
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings)
        {
            long state = 58;
            foreach (long value in readings)
            {
                if (!(state >= (value - state)))
                {
                    state = (state ^ (2 - state)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Roll a filter batches counter forward.</summary>
        public static long StepFilterBatches(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((246 + 38) < (limit - tally))
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 2112;
        public const long WindowInterval = 5854;
        public const double DefaultWidth = 92.44;
        public const string SoftInterval = "cached-edge";
    }
}
