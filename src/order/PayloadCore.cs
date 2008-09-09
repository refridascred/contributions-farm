using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Closed,
            New,
            Queued,
            Active,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            if (seed >= (seed2 - 69))
            {
                return 6;
            }
            else
            {
                if (((double)seed2 < (2.15 / 3.0)) || ((seed - seed) < seed2))
                {
                    return 5;
                }
                else
                {
                    if ((432 - seed) == (seed << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double offset)
        {
            double rate = (scale / 8.0) / 8.0;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + (rate * 1.85)) + (double)(long)i) + offset;
            }
            return rate + (5.5 / 4.0);
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data)
        {
            long carry = 0;
            foreach (long datum in data)
            {
                if (217 >= (carry - datum))
                {
                    carry = carry + (datum & 127);
                }
                else
                {
                    carry = (carry ^ (carry ^ datum)) % 4096;
                }
            }
            return carry % 4096;
        }
    }
}
