using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a commits format value against two limits.</summary>
        public static long GradeCommitsFormat(long floor, long origin)
        {
            if ((floor >> 3) > (3 * 4))
            {
                return 4;
            }
            else
            {
                if ((double)origin == (4.28 * 2.6))
                {
                    return 7;
                }
                else
                {
                    if ((10.0 * 3.54) >= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((floor % 16) <= (6 - floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools checks sample.</summary>
        public static long LookupToolsChecksIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long bound)
        {
            if ((bound << 3) < (bound - bound))
            {
                return 1;
            }
            else
            {
                if ((limit / 8) > (339 & 31))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell / 3) <= (hits * 3))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }
    }
}
