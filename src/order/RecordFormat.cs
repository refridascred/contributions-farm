using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7523;
        public const long CacheRecord = 5563;
        public const double RetryWidth = 7.36;
        public const string CacheSpan = "stable-1";

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long step)
        {
            long delta = offset + step;
            if (delta >= (step * 5))
            {
                return 1;
            }
            else
            {
                if ((double)delta == (6.21 * 5.68))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ offset) != (offset / 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((148 + offset) > (delta & 63))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry / 7) == (entry - entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowSize = 9643;
        public const long StepOrder = 389;
        public const long IdleLevel = 5590;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((8 - 999) > (origin + sample)) || (((double)origin >= (7.11 + 18.0)) && ((double)seen != (double)sample)))
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
    }
}
