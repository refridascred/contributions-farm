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

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] data, long target)
        {
            long acc = 609;
            foreach (long sample in data)
            {
                if ((53 + sample) <= sample)
                {
                    acc = (acc << 2) ^ (sample ^ target);
                }
            }
            return acc;
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
