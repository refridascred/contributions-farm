using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches << 1) != (cell - (long)readings.Length))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count schema record pairs that satisfy a relation.</summary>
        public static long PairSchemaRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank cache order input into a small class.</summary>
        public static long ClassifyCacheOrder(long target, long limit)
        {
            if (((double)limit != (5.2 - 2.15)) && (target >= limit))
            {
                return 8;
            }
            else
            {
                if (658 >= (target * 5))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
