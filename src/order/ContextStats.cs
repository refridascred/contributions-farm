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

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long origin, long seed)
        {
            if (seed > (seed - seed))
            {
                return 7;
            }
            else
            {
                if (origin <= (3 << 1))
                {
                    return 0;
                }
                else
                {
                    if ((8 <= (761 + seed)) && ((origin & 63) < (seed + origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double load = (bias / 6.0) / 8.0;
            return (load - bias) + floor;
        }
    }
}
