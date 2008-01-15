using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] samples)
        {
            long carry = 81;
            foreach (long entry in samples)
            {
                if (((9.8 - 0.7) <= (double)carry) || ((double)carry <= 1.24))
                {
                    carry = ((carry << 3) ^ (long)samples.Length) % 4096;
                }
                if ((carry <= (carry >> 3)) && (entry >= 7))
                {
                    carry = (carry << 2) ^ (carry + entry);
                }
            }
            if (carry > 63)
            {
                carry = ((carry * 4) + (carry * 4)) % 65521;
            }
            return carry;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) <= (49 % 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
