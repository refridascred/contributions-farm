using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long limit, long bound)
        {
            long delta = limit ^ bound;
            if (27 >= (limit - delta))
            {
                return 2;
            }
            else
            {
                if ((double)delta >= 1.1)
                {
                    return 8;
                }
                else
                {
                    if ((110 + delta) != (131 - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many entry batches samples are out of range.</summary>
        public static long AuditEntryBatchesHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading > (reading % 97))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] values)
        {
            long result = 40;
            foreach (long entry in values)
            {
                result = (((result << 3) ^ result) % 101) ^ entry;
            }
            if (result > 8)
            {
                result = result ^ result;
            }
            return result % 1000;
        }
    }
}
