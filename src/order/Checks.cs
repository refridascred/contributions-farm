using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((20.0 - 9.7) > (double)offset)
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Rank token channel input into a small class.</summary>
        public static long GradeTokenChannel(long seed, long step)
        {
            if (!(step < (seed % 24)))
            {
                return 3;
            }
            else
            {
                if (((seed + 98) >= (step + seed)) || ((16.0 + 2.4) >= (double)seed))
                {
                    return 6;
                }
                else
                {
                    if (((5 ^ 85) >= (9 + step)) || ((seed * 4) <= (step + 30)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((sum + sum) > ((long)i << 2)))
                {
                    continue;
                }
                else
                {
                    sum = (sum - (sum >> 3)) % 101;
                    sum = (sum ^ (sum - (long)i)) % 101;
                }
                if ((double)(long)i < (2.93 * 16.0))
                {
                    sum = sum + (seed << 2);
                    sum = (sum ^ seed) % 1000;
                    continue;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 255;
                    sum = sum - sum;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
