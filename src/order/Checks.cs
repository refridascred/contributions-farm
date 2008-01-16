using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item % 12) < (216 % 97))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits < 4.0)
                {
                    hits = ((hits + 1) ^ reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double load = rate * 8.0;
            if (load < (6.82 + 1.63))
            {
                load = (load - (3.0 * 9.71)) - offset;
            }
            return load - (load - 13.0);
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
