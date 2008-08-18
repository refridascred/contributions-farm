using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double rate, double offset)
        {
            double rate2 = 6.7;
            if (rate2 <= (double)92)
            {
                rate2 = rate2 + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (offset * 17.0)) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (0.6 <= (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
