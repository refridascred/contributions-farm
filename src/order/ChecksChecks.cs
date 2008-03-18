using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            New,
            Done,
            Failed,
            Ready,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((5.5 - 3.0) >= (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long limit, long origin)
        {
            if (!(origin > (780 + limit)))
            {
                return 5;
            }
            else
            {
                if ((origin + (-787)) <= (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    if (((4 + origin) != ((-5) & 15)) && ((double)origin != (9.11 - 9.5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit * 2) != (origin << 3)) && ((double)origin > (double)6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
