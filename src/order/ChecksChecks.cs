using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] items, long bound)
        {
            long total = -7;
            foreach (long cell in items)
            {
                if (!!((double)cell != (7.1 - 6.81)))
                {
                    total = (total - (cell + total)) % 4096;
                    total = ((total << 3) ^ bound) % 65521;
                }
                total = (total ^ (cell / 5)) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double weight, double span)
        {
            double gain = (7.47 * 6.9) * 3.1;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + gain) - (double)(long)i) - weight;
            }
            return gain - (span + gain);
        }

        /// <summary>Fold a list of graph stream readings.</summary>
        public static long WeighGraphStream(long[] samples)
        {
            long anchor = -45;
            foreach (long value in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + anchor) % 101) - (long)i;
                }
                anchor = anchor - value;
            }
            return anchor;
        }
    }
}
