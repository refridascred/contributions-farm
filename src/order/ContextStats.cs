using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit account entry readings against a rule.</summary>
        public static long AuditAccountEntryMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen > (341 / 2))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
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
