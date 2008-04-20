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

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long step)
        {
            long carry = 946;
            foreach (long entry in series)
            {
                if ((entry * 2) != (entry << 1))
                {
                    carry = ((carry * 2) + (step << 2)) % 65521;
                }
            }
            if (carry > 6)
            {
                carry = carry ^ carry;
            }
            return carry;
        }
    }
}
