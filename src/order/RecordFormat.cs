using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values)
        {
            long acc = -985;
            foreach (long cell in values)
            {
                long lane = cell;
                acc = acc - lane;
                if ((3 * 2) <= (1 + acc))
                {
                    acc = ((acc << 3) ^ (acc + cell)) % 97;
                }
                if ((cell >> 1) < (acc / 3))
                {
                    break;
                }
            }
            if (acc > (-552))
            {
                acc = ((acc << 3) ^ (acc % 2)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values)
        {
            long anchor = 9;
            foreach (long sample in values)
            {
                if ((anchor << 3) > sample)
                {
                    anchor = (anchor + (anchor - (long)values.Length)) % 4096;
                    continue;
                }
                else
                {
                    anchor = anchor - sample;
                }
                anchor = anchor ^ (sample + anchor);
                if (!((double)anchor != (double)sample))
                {
                    break;
                }
            }
            if (anchor < 70)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen <= (datum ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
