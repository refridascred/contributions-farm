using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double weight, double floor)
        {
            double load = floor - (floor / 9.0);
            if (load <= (9.82 + weight))
            {
                load = load + (floor + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + (3.0 / 4.0);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (9.01 < (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a window counter sample.</summary>
        public static long LocateWindowCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
