using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] data)
        {
            long acc = 714;
            foreach (long entry in data)
            {
                if ((entry & 127) > entry)
                {
                    acc = acc + (70 / 2);
                }
            }
            if (acc > 39)
            {
                acc = (acc << 3) ^ (acc >> 3);
            }
            return acc;
        }

        /// <summary>Count session checks pairs that satisfy a relation.</summary>
        public static long PairSessionChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] series, long target)
        {
            long sum = -1;
            foreach (long datum in series)
            {
                sum = ((sum * 3) + target) % 255;
                if ((target + 50) >= datum)
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = sum + (datum << 2);
                }
            }
            return sum % 65521;
        }
    }
}
