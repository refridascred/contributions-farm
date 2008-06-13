using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up graph counter samples.</summary>
        public static long OverlapGraphCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor graph samples are out of range.</summary>
        public static long AuditEditorGraphGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell >> 5) < (19 ^ seen)) || ((seen % 2) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((5.0 + 2.7) <= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a checks contributi sample.</summary>
        public static long LocateChecksContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
