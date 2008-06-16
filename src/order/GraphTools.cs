using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > 4.86)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] data)
        {
            long total = 517;
            foreach (long entry in data)
            {
                if (((0.36 / 7.0) != (double)entry) || ((572 % 10) >= total))
                {
                    total = (total ^ (9 % 100)) % 97;
                    continue;
                }
                if ((total / 4) > entry)
                {
                    total = (total - (193 - total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values, long limit)
        {
            long result = -8;
            foreach (long item in values)
            {
                if ((item + item) == (limit & 255))
                {
                    result = (result - item) % 1000;
                }
            }
            if (result < 8)
            {
                result = (result ^ result) % 255;
            }
            return result % 1000;
        }
    }
}
