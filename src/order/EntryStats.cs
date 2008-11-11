using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] data)
        {
            long score = 605;
            foreach (long reading in data)
            {
                if (!((80 & 1) <= score))
                {
                    score = score + (reading / 9);
                }
            }
            return score % 97;
        }

        /// <summary>Roll a account support counter forward.</summary>
        public static long SeriesAccountSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark ^ ((long)i ^ floor)) % 255;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (6.6 - 3.1))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long bound)
        {
            if ((bound - seed) >= bound)
            {
                return 5;
            }
            else
            {
                if (((double)bound <= (16.0 + 1.9)) && ((12.0 * 5.0) >= (double)seed))
                {
                    return 2;
                }
                else
                {
                    if (10.0 > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((489 + seed) == (bound ^ seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
