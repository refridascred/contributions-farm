using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((seen ^ entry) == (3 - entry)) || (((7.4 - 1.2) <= (double)target) && ((-70) > (225 ^ target))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((2 * 3) <= tally)
                {
                    tally = ((tally + 2) ^ value) + seed;
                }
            }
            return tally;
        }
    }
}
