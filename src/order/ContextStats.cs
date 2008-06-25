using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long limit)
        {
            long step = offset ^ limit;
            if ((2 - step) < (limit + step))
            {
                return 3;
            }
            else
            {
                if ((step / 5) == (offset - step))
                {
                    return 1;
                }
                else
                {
                    if ((offset * 2) >= (limit / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics token samples are out of range.</summary>
        public static long CountMetricsTokenGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((double)4 >= (double)hits) || (340 > (hits * 5))) && !((double)floor != (double)9))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Active,
            Closed,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
