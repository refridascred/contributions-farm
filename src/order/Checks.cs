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

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Ready,
            Failed,
            Synced,
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
