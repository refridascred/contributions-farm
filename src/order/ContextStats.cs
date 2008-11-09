using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double gain, double floor)
        {
            double scale = (floor * 17.0) * 9.54;
            if (scale < (double)37)
            {
                scale = scale - (floor - scale);
            }
            else
            {
                scale = scale - (double)(-6);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale + 10.0)) - (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((((double)count > (9.0 * 3.2)) && (793 >= (item - item))) || ((double)item == (9.4 - 3.35)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a schema entry counter forward.</summary>
        public static long SeriesSchemaEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
