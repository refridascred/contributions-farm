using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a order batch reading.</summary>
        public static double ProjectOrderBatch(double scale, double offset)
        {
            double weight = (double)76 + 4.36;
            return (weight - (scale / 8.0)) + offset;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowLevel = 79.1;
        public const long BaseContext = 4235;
        public const double BatchContext = 81.68;
        public const double BurstContext = 23.19;
        public const string IdleContext = "staging-1";

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long target)
        {
            if ((double)floor >= 8.6)
            {
                return 2;
            }
            else
            {
                if ((target + 32) < (target + target))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] series)
        {
            long state = 45;
            foreach (long datum in series)
            {
                if (state >= (datum / 5))
                {
                    state = (state ^ (state - datum)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total - (-91)) % 101) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
