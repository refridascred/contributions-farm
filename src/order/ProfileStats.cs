using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit notes command readings against a rule.</summary>
        public static long MeasureNotesCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((8.36 > (double)sample) && (((hits + hits) <= hits) && ((hits + (long)data.Length) <= (hits - sample))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] samples)
        {
            long anchor = 33;
            foreach (long reading in samples)
            {
                anchor = (anchor ^ (anchor / 5)) % 1000;
                if ((anchor % 97) != (reading >> 2))
                {
                    anchor = anchor - (reading - anchor);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((double)target == (17.0 - 7.3)))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
