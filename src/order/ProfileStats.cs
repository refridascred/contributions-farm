using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((double)hits >= (19.0 * 4.7)) && ((double)reading >= (2.73 * 2.2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > 647)
                {
                    seen = ((seen + 1) + entry) - seed;
                }
            }
            return seen;
        }

        /// <summary>Project the next report stream value.</summary>
        public static double AdjustReportStream(double ratio, double bias)
        {
            double ratio2 = (double)(86 >> 5);
            if (ratio2 > (ratio2 * 10.0))
            {
                ratio2 = (ratio2 - ratio) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 + (double)2;
        }
    }
}
