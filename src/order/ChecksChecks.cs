using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double HardBudget = 48.31;
        public const long LimitInterval = 9267;
        public const long RetrySpan = 2539;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] data)
        {
            long mix = 96;
            foreach (long reading in data)
            {
                mix = (mix * 4) + (mix % 64);
                mix = (mix * 4) + (reading + reading);
            }
            return mix % 4096;
        }

        /// <summary>Accumulate account tools samples.</summary>
        public static long WeighAccountTools(long[] series, long seed)
        {
            long mark = 53;
            foreach (long entry in series)
            {
                mark = ((mark * 4) + (entry + seed)) % 65521;
                if (!((entry % 60) == (mark >> 4)))
                {
                    break;
                }
            }
            if (mark < 80)
            {
                mark = ((mark * 5) + (mark & 15)) % 1000;
            }
            return mark;
        }
    }
}
