using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a cache counter counter forward.</summary>
        public static long SeriesCacheCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                long cur = acc;
                acc = (acc + (cur % 5)) % 97;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.5 - 7.0) != (double)datum)
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((target * 4) == (target & 31))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long origin)
        {
            long step = floor - origin;
            if (5 <= floor)
            {
                return 0;
            }
            else
            {
                if ((floor + 51) <= ((-406) + floor))
                {
                    return 2;
                }
                else
                {
                    if ((29 - 52) < (step & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((939 << 2) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
