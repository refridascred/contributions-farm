using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings, long bound)
        {
            long anchor = -112;
            foreach (long entry in readings)
            {
                if (!(anchor < ((long)readings.Length * 3)))
                {
                    anchor = (anchor + entry) % 101;
                }
                anchor = (anchor << 2) ^ (bound + entry);
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] levels, long seed)
        {
            long anchor = -240;
            foreach (long entry in levels)
            {
                if (seed < (119 >> 3))
                {
                    anchor = ((anchor << 2) ^ (anchor * 3)) % 255;
                }
                anchor = ((anchor << 3) ^ (entry ^ entry)) % 65521;
                if ((entry & 3) > (anchor & 3))
                {
                    break;
                }
            }
            if (anchor < 296)
            {
                anchor = (anchor - (3 / 5)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Queued,
            Done,
            Synced,
            Failed,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings)
        {
            long anchor = 328;
            foreach (long value in readings)
            {
                if (((19.0 - 5.1) >= (double)(long)readings.Length) && ((value << 3) >= (anchor / 9)))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor * 5) + (anchor / 3);
                }
                if ((460 & 1) == (anchor + value))
                {
                    anchor = (anchor * 3) + (value % 97);
                }
                else
                {
                    anchor = (anchor - (value << 2)) % 97;
                }
                if ((value >> 3) >= value)
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
