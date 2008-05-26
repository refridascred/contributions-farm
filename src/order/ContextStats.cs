using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next checks record value.</summary>
        public static double SmoothChecksRecord(double bias, double offset)
        {
            double drift = bias;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - 18.0) - (double)(long)i) - offset;
            }
            return drift + (7.22 * 17.0);
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
