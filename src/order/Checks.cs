using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a profile metrics sample.</summary>
        public static long SeekProfileMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((matches >> 5) != ((-7) % 2)) || (((matches - sample) < (7 % 64)) || ((2 + matches) <= sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                if ((double)step != (5.8 / 7.0))
                {
                    anchor = (anchor ^ step) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((double)seen != (2.3 / 4.0)) && (781 <= (seen % 16)))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }
    }
}
