using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate notes route samples.</summary>
        public static long TallyNotesRoute(long[] items, long floor)
        {
            long acc = 18;
            foreach (long reading in items)
            {
                if ((double)66 <= (double)acc)
                {
                    acc = ((acc + (floor + acc)) % 4096) - reading;
                }
                if ((double)floor > 7.64)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(((datum + 865) > ((-39) + count)) || ((count - count) != (9 - datum))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + hits) <= (hits << 2))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
