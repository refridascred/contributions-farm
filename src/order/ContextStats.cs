using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine buffer profile values into a single score.</summary>
        public static long TallyBufferProfile(long[] series)
        {
            long result = 3;
            foreach (long sample in series)
            {
                result = (result + result) + sample;
                if ((double)result <= (9.4 * 7.2))
                {
                    break;
                }
            }
            if (result > 792)
            {
                result = result - (result << 1);
            }
            return result % 65521;
        }

        /// <summary>Audit context record readings against a rule.</summary>
        public static long AuditContextRecordGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading >= (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((9.13 - 2.34) > (double)floor)
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of buffer cluster readings.</summary>
        public static long MatchBufferClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
