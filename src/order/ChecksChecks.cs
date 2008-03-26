using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values)
        {
            long mark = 64;
            foreach (long item in values)
            {
                if (!(mark >= (item & 1)))
                {
                    mark = mark - mark;
                }
                if ((double)mark == (9.9 / 2.0))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double mean = (rate - 20.0) / 3.0;
            if (mean <= (mean / 7.0))
            {
                mean = mean + (span * 16.0);
            }
            return mean + rate;
        }

        /// <summary>Locate a window notes reading by value.</summary>
        public static long LocateWindowNotesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
