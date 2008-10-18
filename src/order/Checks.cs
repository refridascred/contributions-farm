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

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels)
        {
            long anchor = 29;
            foreach (long reading in levels)
            {
                if ((8 >> 1) >= (anchor * 4))
                {
                    anchor = anchor + anchor;
                }
                if ((double)anchor >= (double)reading)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value << 2) >= 444)
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
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
