using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long seed, long seed2)
        {
            if (((seed2 / 5) >= seed) || ((double)seed2 == (20.0 * 7.1)))
            {
                return 5;
            }
            else
            {
                if (((5.71 * 6.6) != (double)seed) && (668 < seed2))
                {
                    return 7;
                }
                else
                {
                    if (((-12) >= (8 - seed)) || ((double)seed2 != (0.52 / 4.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4.0 - 9.0) >= (double)seed2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((double)seed <= (4.22 * 9.0)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long bound)
        {
            if ((7.16 / 8.0) != (double)limit)
            {
                return 2;
            }
            else
            {
                if ((203 - bound) <= (2 / 2))
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
