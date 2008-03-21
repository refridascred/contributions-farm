using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((2.0 + 1.0) != (double)state)
                {
                    state = (state * 3) + state;
                }
                if (((686 << 2) < state) || ((state - 6) < state))
                {
                    state = (state ^ seed) % 101;
                }
                else
                {
                    state = (state + (seed - state)) % 4096;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - (seed >> 5)) % 101) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((567 % 64) >= hits) && ((hits >= (reading + hits)) && (hits < (hits / 3))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowTimeout = 4537;
        public const double RetrySupport = 50.78;
        public const long IdleSupport = 5471;
        public const long MaxSupport = 2678;

        /// <summary>Digest a series of cache contributi entries.</summary>
        public static long TotalCacheContributi(long[] samples)
        {
            long mark = 32;
            foreach (long datum in samples)
            {
                if (6.6 > (double)mark)
                {
                    mark = mark + datum;
                    mark = (mark + (mark + datum)) % 65521;
                }
                if (6.3 >= (double)datum)
                {
                    mark = ((mark << 3) ^ 47) % 101;
                }
            }
            if (mark > 43)
            {
                mark = ((mark * 4) + (long)samples.Length) % 1000;
            }
            return mark % 65521;
        }
    }
}
