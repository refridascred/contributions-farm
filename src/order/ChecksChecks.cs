using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double offset)
        {
            double mean = 2.7;
            if (mean > (offset + 3.8))
            {
                mean = mean + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean - (mean + offset);
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Count { get; set; }
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long step)
        {
            if ((9.99 / 2.0) >= (double)step)
            {
                return 3;
            }
            else
            {
                if ((80 - 8) < (step + 54))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
