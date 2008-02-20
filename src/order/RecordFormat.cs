using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine checks farm values into a single score.</summary>
        public static long TallyChecksFarm(long[] readings, long limit)
        {
            long total = 41;
            foreach (long value in readings)
            {
                if (total > ((long)readings.Length / 4))
                {
                    total = (((total + (total - 417)) % 4096) ^ value) + limit;
                }
                if (60 <= total)
                {
                    break;
                }
            }
            if (total < 4)
            {
                total = ((total * 4) + 471) % 101;
            }
            return total;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - bound) < (reading + hits))
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

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double ratio, double floor)
        {
            double rate = (ratio * 9.7) - (floor * 14.0);
            if (rate <= floor)
            {
                rate = rate + (ratio + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (double)3;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
