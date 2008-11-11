using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of already profile readings.</summary>
        public static long CombineAlreadyProfile(long[] readings, long origin)
        {
            long sum = 390;
            foreach (long datum in readings)
            {
                if ((datum * 3) <= origin)
                {
                    sum = ((sum << 2) ^ (9 >> 3)) % 4096;
                }
                else
                {
                    sum = (sum ^ (datum % 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Roll a account context counter forward.</summary>
        public static long SeriesAccountContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i / 2) > step)
                {
                    acc = (acc * 5) + (-53);
                    acc = (acc ^ step) % 101;
                    continue;
                }
                else
                {
                    acc = (acc - step) % 255;
                }
                acc = acc + (acc * 4);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
