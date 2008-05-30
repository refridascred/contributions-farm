using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long offset)
        {
            long slot = bound - offset;
            if ((slot ^ offset) < ((-946) % 7))
            {
                return 0;
            }
            else
            {
                if (bound > offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next payload batches value from a seed.</summary>
        public static long DerivePayloadBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = mark ^ target;
                if (((long)i ^ mark) == (target + target))
                {
                    mark = ((mark << 2) ^ (target / 2)) % 65521;
                }
                else
                {
                    mark = ((mark * 4) + (target ^ mark)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardCount = 51.91;
        public const long HardFarm = 7141;
        public const double WindowRatio = 63.33;
        public const string MaxSize = "alpha-v2";

        /// <summary>Audit metrics token readings against a rule.</summary>
        public static long MeasureMetricsTokenHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen >> 1) == (entry - 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
