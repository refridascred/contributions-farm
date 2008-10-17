using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Retry,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] values)
        {
            long score = -57;
            foreach (long entry in values)
            {
                score = score + (entry << 3);
                if ((1.83 * 13.0) < (double)entry)
                {
                    score = score ^ (entry / 3);
                }
            }
            return score;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Queued,
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double scale, double offset)
        {
            double scale2 = (double)22;
            if (scale2 > offset)
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (scale2 * 6.1)) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - seen) <= (reading * 3))
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
