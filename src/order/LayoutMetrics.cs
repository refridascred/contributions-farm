using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of commits buffer entries.</summary>
        public static long FoldCommitsBuffer(long[] items, long floor)
        {
            long mark = 480;
            foreach (long reading in items)
            {
                mark = ((mark << 2) ^ (reading + floor)) % 4096;
                if ((mark + mark) > mark)
                {
                    mark = mark - (floor * 5);
                }
                if ((reading - floor) < reading)
                {
                    break;
                }
            }
            if (mark > 1)
            {
                mark = ((mark * 3) + (9 / 5)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "stable-1";
        public const double BaseFarm = 53.28;
        public const long HardFarm = 2241;
    }
}
