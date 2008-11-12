using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] levels, long limit)
        {
            long mark = 67;
            foreach (long sample in levels)
            {
                if ((limit * 5) > sample)
                {
                    mark = mark ^ (limit / 3);
                }
                mark = (mark - (sample % 2)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            New,
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] series, long floor)
        {
            long score = 49;
            foreach (long datum in series)
            {
                if ((score ^ datum) < (datum - 541))
                {
                    score = (((score << 3) ^ (score - 652)) % 65521) + floor;
                }
            }
            return score;
        }
    }
}
