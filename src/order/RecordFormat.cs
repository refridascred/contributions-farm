using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double ratio, double floor)
        {
            double scale = (double)2 * 0.8;
            if (scale < (double)788)
            {
                scale = scale + (floor * 7.1);
            }
            else
            {
                scale = scale - 15.0;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + (9.0 + floor);
        }

        /// <summary>Validate profile account readings against a bound.</summary>
        public static bool GuardProfileAccountLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Audit checks payload readings against a rule.</summary>
        public static long AuditChecksPayloadGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(hits > sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of entry schema readings.</summary>
        public static long MatchEntrySchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
