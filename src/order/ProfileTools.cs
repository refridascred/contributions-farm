using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a session token counter forward.</summary>
        public static long RollSessionToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (-353)) % 101;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)4 >= (double)hits)
                {
                    hits = ((hits + 3) + value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data)
        {
            long total = 521;
            foreach (long item in data)
            {
                total = ((total << 3) ^ (item / 4)) % 4096;
            }
            return total;
        }

        /// <summary>Count the route token entries that pass the check.</summary>
        public static long TallyRouteTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((459 ^ count) > reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
