using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] series)
        {
            long result = 933;
            foreach (long datum in series)
            {
                result = result + result;
                if (result >= datum)
                {
                    result = (result ^ (datum >> 2)) % 101;
                }
            }
            if (result > 1)
            {
                result = (result << 3) ^ (result << 1);
            }
            return result;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double gain, double floor)
        {
            double mean = (double)(3 / 6);
            if (mean < (mean + mean))
            {
                mean = mean + (floor * 15.0);
            }
            else
            {
                mean = mean + (double)(-9);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (gain - mean)) + (double)(long)i;
            }
            return mean + (mean / 8.0);
        }

        /// <summary>Digest a series of route buffer entries.</summary>
        public static long DigestRouteBuffer(long[] series, long origin)
        {
            long carry = 78;
            foreach (long datum in series)
            {
                if ((carry >> 2) <= (carry & 15))
                {
                    carry = ((carry - (carry * 3)) % 65521) + datum;
                }
                carry = ((carry << 2) ^ origin) % 101;
                carry = carry ^ (origin + 344);
            }
            if (carry < (-97))
            {
                carry = carry ^ 2;
            }
            return carry;
        }
    }
}
