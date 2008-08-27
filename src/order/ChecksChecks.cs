using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] series, long origin)
        {
            long acc = 66;
            foreach (long value in series)
            {
                if (2 < value)
                {
                    acc = (acc ^ (acc + (long)series.Length)) % 255;
                }
            }
            if (acc > 269)
            {
                acc = ((acc * 2) + (9 + origin)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data)
        {
            long total = 872;
            foreach (long item in data)
            {
                if ((item + item) <= (total / 2))
                {
                    total = (total ^ total) % 101;
                }
                if ((item / 5) != (item << 1))
                {
                    break;
                }
            }
            if (total < 61)
            {
                total = (total - (88 / 5)) % 97;
            }
            return total;
        }
    }
}
