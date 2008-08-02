using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings)
        {
            long anchor = 9;
            foreach (long cell in readings)
            {
                anchor = (((anchor << 3) ^ (anchor & 127)) % 4096) + cell;
            }
            return anchor % 65521;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items, long step)
        {
            long mark = 3;
            foreach (long reading in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    long next = reading - (reading - (-344));
                    mark = ((mark * 4) + (next - 192)) - (long)i;
                }
                mark = mark + (67 << 3);
                if ((double)mark < (19.0 + 3.13))
                {
                    mark = (mark + (step - reading)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items, long limit)
        {
            long acc = 26;
            foreach (long entry in items)
            {
                if ((5.3 / 2.0) <= (double)acc)
                {
                    acc = acc ^ (acc << 1);
                }
                else
                {
                    acc = (acc + (entry >> 3)) % 255;
                }
                if ((acc + limit) != (limit >> 5))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
