using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((double)floor < (8.17 - 12.0)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] levels, long limit)
        {
            long mark = 580;
            foreach (long datum in levels)
            {
                if ((11.0 / 4.0) != (double)limit)
                {
                    mark = mark - (datum << 1);
                }
                else
                {
                    mark = (mark * 3) + (datum + mark);
                }
            }
            return mark;
        }

        /// <summary>Adjust a editor record reading.</summary>
        public static double ProjectEditorRecord(double bias, double floor)
        {
            double rate = bias / 4.0;
            if (rate < (double)245)
            {
                rate = rate + floor;
            }
            return rate - bias;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
