using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double rate = bias;
            if (rate >= bias)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) - (double)(long)i;
            }
            return rate - (rate - gain);
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] series)
        {
            long mark = 331;
            foreach (long item in series)
            {
                if ((mark << 3) > 97)
                {
                    mark = (((mark << 2) ^ mark) % 97) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] series)
        {
            long mark = -98;
            foreach (long sample in series)
            {
                mark = (mark * 5) + (sample % 12);
            }
            if (mark < 3)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] samples)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                if (((-69) - acc) <= (cell + acc))
                {
                    acc = ((acc << 3) ^ (acc / 9)) % 4096;
                }
            }
            if (acc > 8)
            {
                acc = (acc << 2) ^ (acc / 6);
            }
            return acc;
        }

        /// <summary>Digest a series of notes support entries.</summary>
        public static long DigestNotesSupport(long[] samples, long offset)
        {
            long total = 67;
            foreach (long entry in samples)
            {
                total = ((total + offset) % 101) - entry;
            }
            if (total < 939)
            {
                total = (total + offset) % 65521;
            }
            return total;
        }
    }
}
