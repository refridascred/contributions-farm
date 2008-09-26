using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values, long origin)
        {
            long sum = 931;
            foreach (long sample in values)
            {
                sum = sum + (origin + 874);
                sum = (sum - (sum + sample)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] items)
        {
            long mix = -5;
            foreach (long entry in items)
            {
                mix = (mix - 874) % 101;
                if (((mix * 5) < mix) || ((long)items.Length >= (entry + entry)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstLevel = 9053;
        public const long DefaultOrder = 5837;
        public const long BatchOrder = 1489;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double load = 3.6;
            if (load > (double)96)
            {
                load = load - 9.2;
            }
            else
            {
                load = load + (rate * 14.0);
            }
            return load - offset;
        }
    }
}
