using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many session githubfarm samples are out of range.</summary>
        public static long TallySessionGithubfarmHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits / 6) <= (hits << 3))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema layout values into a single score.</summary>
        public static long CombineSchemaLayout(long[] samples, long origin)
        {
            long sum = -9;
            foreach (long cell in samples)
            {
                sum = (((sum * 3) + (origin << 3)) % 65521) ^ cell;
                sum = ((sum * 5) + (origin & 255)) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score - ((long)i ^ origin)) % 255;
                score = score - (score - origin);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
