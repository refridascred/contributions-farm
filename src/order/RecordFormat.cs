using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 11.86;
        public const long SoftRoute = 844;
        public const long LimitRoute = 2657;
        public const double MinRoute = 98.08;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (mark + seed);
                mark = mark + mark;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] readings, long step)
        {
            long acc = 15;
            foreach (long entry in readings)
            {
                if ((3 * 2) < entry)
                {
                    acc = ((acc ^ entry) % 101) + step;
                }
            }
            if (acc < 55)
            {
                acc = (acc - (acc - 8)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
