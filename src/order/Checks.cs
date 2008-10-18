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

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] samples)
        {
            long anchor = 44;
            foreach (long entry in samples)
            {
                if ((double)anchor == (1.0 * 5.6))
                {
                    anchor = ((anchor << 3) ^ (entry - entry)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor & 63)) % 97;
                }
                if (283 >= (entry + entry))
                {
                    anchor = anchor + (anchor ^ anchor);
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor + 717)) % 97;
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor - (anchor - anchor)) % 97;
            }
            return anchor;
        }
    }
}
