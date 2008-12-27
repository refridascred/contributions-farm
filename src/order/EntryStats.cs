using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((3.0 / 6.0) >= (double)(long)items.Length) || (760 >= sample)) && ((6.0 * 13.0) <= (double)(long)items.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((count < (370 % 10)) && (count > (count ^ sample))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            Draft,
            New,
        }
    }
}
