using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum >= (hits + datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank support notes input into a small class.</summary>
        public static long RankSupportNotes(long floor, long floor2)
        {
            long next = floor - floor2;
            if ((floor + floor2) >= (6 ^ floor))
            {
                return 3;
            }
            else
            {
                if ((floor / 4) <= (0 + floor2))
                {
                    return 4;
                }
                else
                {
                    if (((double)next <= (13.0 - 6.42)) || ((2.87 - 6.0) >= (double)next))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor2 == (7.5 * 9.6))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
