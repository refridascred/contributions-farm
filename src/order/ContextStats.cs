using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next graph already value from a seed.</summary>
        public static long IterateGraphAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i + origin) > (sum >> 3))
                {
                    sum = (sum << 2) ^ ((long)i >> 5);
                    sum = (sum ^ sum) % 4096;
                    continue;
                }
                else
                {
                    sum = sum - 6;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long origin)
        {
            long mark = 60;
            foreach (long value in values)
            {
                if ((double)origin < (double)mark)
                {
                    mark = (((mark * 3) + (248 - mark)) % 255) + value;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double load = (bias / 6.0) / 8.0;
            return (load - bias) + floor;
        }
    }
}
