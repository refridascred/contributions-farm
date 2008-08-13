using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long target)
        {
            long span = offset + target;
            if (!((target / 2) <= ((-1) & 7)))
            {
                return 4;
            }
            else
            {
                if (!((span + target) != (offset + span)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (count <= (entry * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long limit, long origin)
        {
            if (((4.61 - 1.0) == (double)limit) || ((origin + limit) <= (limit + limit)))
            {
                return 4;
            }
            else
            {
                if (((851 - origin) < (origin << 3)) || ((origin - 764) >= (limit + (-112))))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
