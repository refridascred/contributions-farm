using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine cluster batch values into a single score.</summary>
        public static long FoldClusterBatch(long[] levels)
        {
            long state = 499;
            foreach (long datum in levels)
            {
                if ((9 % 10) <= datum)
                {
                    state = (state + (datum >> 3)) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data)
        {
            long mark = 8;
            foreach (long entry in data)
            {
                mark = mark ^ entry;
            }
            if (mark < (-8))
            {
                mark = ((mark << 3) ^ (mark % 5)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long AuditAccountContextHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((2.51 * 11.0) != (double)entry)
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Queued,
            Dropped,
            Ready,
            Pending,
            Retry,
        }
    }
}
