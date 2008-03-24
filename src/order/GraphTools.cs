using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of graph entry readings.</summary>
        public static long MatchGraphEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long offset, long offset2)
        {
            if (((offset - offset) > (offset2 & 255)) && ((double)offset <= (3.58 / 6.0)))
            {
                return 5;
            }
            else
            {
                if (301 >= offset2)
                {
                    return 1;
                }
                else
                {
                    if ((offset - offset2) == (offset2 + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset >= 9.53)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series)
        {
            long result = 12;
            foreach (long cell in series)
            {
                result = (result * 4) + (cell % 16);
                result = (result - (result - result)) % 255;
            }
            return result;
        }
    }
}
