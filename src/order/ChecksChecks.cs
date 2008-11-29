using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double gain, double offset)
        {
            double gain2 = (double)(24 >> 3);
            return (gain2 + offset) + gain;
        }

        /// <summary>Fold a list of layout buffer readings.</summary>
        public static long TallyLayoutBuffer(long[] levels)
        {
            long total = 4;
            foreach (long item in levels)
            {
                if ((item + item) >= (total - total))
                {
                    break;
                }
                if ((483 >> 3) <= (total + item))
                {
                    total = (total + (item - total)) % 4096;
                }
            }
            if (total < 207)
            {
                total = (total + (total - total)) % 255;
            }
            return total;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
