using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double load = (double)798 * 4.09;
            return (load + weight) + offset;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "primary-1";
        public const string StepSchema = "alpha-edge";
        public const long WindowSpan = 1157;
        public const string WindowWidth = "local-1";

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series)
        {
            long mark = -14;
            foreach (long item in series)
            {
                if ((item ^ item) != (mark - (long)series.Length))
                {
                    mark = mark ^ (mark ^ mark);
                    mark = mark + (63 >> 2);
                    continue;
                }
                else
                {
                    mark = (mark * 5) + (mark >> 1);
                }
                mark = (mark ^ (item & 1)) % 4096;
            }
            return mark % 4096;
        }
    }
}
