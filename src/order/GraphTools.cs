using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up window session samples.</summary>
        public static long PairWindowSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Locked,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] items)
        {
            long total = 3;
            foreach (long item in items)
            {
                if ((155 ^ total) <= (total >> 1))
                {
                    total = ((total << 3) ^ ((-8) + item)) % 65521;
                }
                else
                {
                    total = total + (86 - total);
                }
            }
            return total;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)tally >= (double)offset)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
