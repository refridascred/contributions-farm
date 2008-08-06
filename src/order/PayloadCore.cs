using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 2779;
        public const long SoftLevel = 7261;
        public const string RetryRatio = "cached-edge";
        public const long BatchTools = 3223;
        public const long RetryFactor = 9974;

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] items, long seed)
        {
            long total = 778;
            foreach (long datum in items)
            {
                if ((datum + seed) >= 583)
                {
                    total = (total << 2) ^ datum;
                }
                else
                {
                    total = total ^ seed;
                }
            }
            if (total > (-5))
            {
                total = (total - (long)items.Length) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] values)
        {
            long mix = -3;
            foreach (long value in values)
            {
                if (value < (mix << 1))
                {
                    mix = (mix ^ (value - 36)) % 65521;
                }
                if ((mix % 10) < (mix - value))
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double bias2)
        {
            double gain = bias * 20.0;
            if (gain >= bias)
            {
                gain = gain - (bias2 * 4.58);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (gain + gain)) - (double)(long)i;
            }
            return gain + bias2;
        }
    }
}
