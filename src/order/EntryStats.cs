using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - (long)levels.Length) > value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                if ((score + (long)i) != (target + score))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((double)floor <= (4.82 / 4.0))
                {
                    score = (score - (floor % 64)) % 65521;
                }
                else
                {
                    score = (score ^ (score + 9)) % 4096;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] readings, long seed)
        {
            long mark = 7;
            foreach (long sample in readings)
            {
                if (!(mark >= (seed + 776)))
                {
                    mark = (mark * 2) + (sample << 3);
                }
                else
                {
                    mark = (mark + (mark ^ (long)readings.Length)) % 4096;
                }
            }
            return mark;
        }
    }
}
