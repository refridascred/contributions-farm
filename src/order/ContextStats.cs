using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seed - entry) <= (seed / 9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] values, long target)
        {
            long mark = 251;
            foreach (long reading in values)
            {
                long step = (target >> 5) - (reading ^ target);
                mark = mark - (step << 2);
                if (((double)mark == (double)reading) && ((reading + mark) != (target + mark)))
                {
                    mark = (mark ^ 8) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Retry,
            Locked,
            Active,
            New,
        }
    }
}
