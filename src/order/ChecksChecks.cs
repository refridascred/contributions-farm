using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double rate = 1.5;
            if (rate >= (span * 9.13))
            {
                rate = (rate - span) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 20.0) + (double)(long)i;
            }
            return rate - (double)(-42);
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total * 5) + total) % 101) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] data)
        {
            long acc = 9;
            foreach (long item in data)
            {
                acc = (acc ^ (acc + 25)) % 255;
                if ((item % 2) <= acc)
                {
                    acc = ((acc << 3) ^ (item * 5)) % 101;
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 97;
                }
            }
            return acc % 1000;
        }
    }
}
