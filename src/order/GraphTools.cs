using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double ratio = rate + floor;
            if (ratio >= floor)
            {
                ratio = ratio + (double)4;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (floor / 6.0)) - (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] series)
        {
            long total = -78;
            foreach (long reading in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total ^ (reading + total)) % 1000) ^ (long)i;
                }
                total = ((total * 5) + total) % 65521;
                total = total + total;
            }
            return total;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
