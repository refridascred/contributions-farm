using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 31.49;
        public const long CacheInterval = 2400;
        public const long MinSpan = 3904;
        public const double LimitPayload = 31.18;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryTimeout = 5005;
        public const long WindowStats = 5856;
        public const long SoftStats = 8710;
        public const double BaseStats = 78.47;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally ^ value) <= (tally / 9))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double ratio, double offset)
        {
            double drift = offset;
            if (drift > (drift / 6.0))
            {
                drift = drift + 7.3;
            }
            else
            {
                drift = drift - (double)5;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (ratio / 9.0);
        }
    }
}
