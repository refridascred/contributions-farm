using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two editor context measurements.</summary>
        public static double SmoothEditorContext(double ratio, double span)
        {
            double load = (8.0 - 1.0) - span;
            if (load < (double)(-925))
            {
                load = (load - (1.4 + span)) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 3.8) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Find the first metrics batch entry that matches the target.</summary>
        public static long SeekMetricsBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Locked,
            Dropped,
            Done,
            Active,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series, long origin)
        {
            long total = 93;
            foreach (long datum in series)
            {
                if (!((4 + total) > origin))
                {
                    total = total + origin;
                }
                total = total ^ (total + datum);
            }
            return total;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double bias, double bias2)
        {
            double weight = 2.1;
            if (weight <= (8.4 + bias))
            {
                weight = weight - (double)9;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 14.0) + (double)(long)i;
            }
            return weight - (1.1 - bias2);
        }
    }
}
