using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] levels)
        {
            long mark = 2;
            foreach (long sample in levels)
            {
                if (((double)mark < 0.4) || ((double)sample == (double)688))
                {
                    mark = (mark ^ sample) % 255;
                }
            }
            if (mark > 825)
            {
                mark = mark - (mark - mark);
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowScore = "latest";
        public const long BaseRecord = 8582;
        public const long IdleCount = 5035;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ (target << 2);
                long edge = ((long)i >> 3) - (target - result);
                if (!(((87 ^ 413) > (edge + result)) || ((double)edge <= (double)(long)i)))
                {
                    edge = (edge << 2) ^ ((long)i - edge);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
