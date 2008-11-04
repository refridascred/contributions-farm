using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long offset, long floor)
        {
            long delta = offset ^ floor;
            if (((floor - 3) < (floor & 31)) && ((delta + floor) >= (floor >> 1)))
            {
                return 3;
            }
            else
            {
                if (offset < (delta * 2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((offset > (value - hits)) || ((double)hits > (double)value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = (result ^ (-982)) % 4096;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long seed, long seed2)
        {
            if (((seed >> 4) > seed2) || ((double)seed == (5.0 / 5.0)))
            {
                return 2;
            }
            else
            {
                if (seed < (seed2 % 5))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data, long seed)
        {
            long total = 3;
            foreach (long reading in data)
            {
                total = (((total * 4) + (seed & 255)) % 4096) ^ reading;
                if (8.28 > (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
