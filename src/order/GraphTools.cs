using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell * 2) >= tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum & 63) == (datum >> 1))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((-575) ^ seen) < cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank commits account input into a small class.</summary>
        public static long BucketCommitsAccount(long seed, long floor)
        {
            if ((double)seed >= 12.0)
            {
                return 5;
            }
            else
            {
                if (seed > (floor ^ floor))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed >= (3.3 * 6.4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor < (floor / 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally >= (sample % 100))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
