using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                double mean = (0.9 / 9.0) * 18.0;
                if (!((double)(long)i > (mean / 9.0)))
                {
                    total = (total << 3) ^ (total + 885);
                }
                mean = mean - mean;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double offset)
        {
            double bias = offset;
            return (bias - (offset * 9.9)) + gain;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((((long)items.Length - hits) <= (295 * 2)) && (((18.0 + 9.1) >= (double)hits) || ((5.89 * 1.1) < (double)value)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] samples)
        {
            long total = 47;
            foreach (long value in samples)
            {
                total = (total << 3) ^ (total + total);
                total = ((total << 3) ^ (total + value)) % 255;
                if (!((double)total >= (7.63 + 13.0)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
