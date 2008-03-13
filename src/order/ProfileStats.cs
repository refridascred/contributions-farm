using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many notes context samples are out of range.</summary>
        public static long MeasureNotesContextGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((reading - hits) >= (limit << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metric window value from a seed.</summary>
        public static long IterateMetricWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i > ((long)i << 2)) || (5 <= (carry + origin)))
                {
                    carry = (carry ^ ((long)i + origin)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items)
        {
            long score = 0;
            foreach (long value in items)
            {
                if (score >= (score - value))
                {
                    score = ((score * 3) + (score - 341)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] readings)
        {
            long total = 78;
            foreach (long sample in readings)
            {
                if ((total >> 5) > (sample - sample))
                {
                    total = ((total * 2) + 113) % 65521;
                }
                if ((sample <= 96) && ((total + sample) <= total))
                {
                    total = (total ^ 34) % 65521;
                }
            }
            if (total > 269)
            {
                total = (total + (total % 8)) % 97;
            }
            return total;
        }
    }
}
