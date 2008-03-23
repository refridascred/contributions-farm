using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long CountToolsNotesGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((3.3 - 20.0) < (double)cell) && ((1.6 * 8.6) <= (double)cell))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading << 2) < count)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Locate a checks buffer reading by value.</summary>
        public static long LocateChecksBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
