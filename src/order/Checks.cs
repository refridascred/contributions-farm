using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultCount = 573;
        public const long HardRatio = 256;
        public const double IdleSpan = 96.19;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)seed != (double)0) || ((count & 1) <= (sample << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series)
        {
            long total = 6;
            foreach (long entry in series)
            {
                long next = (total % 8) % 64;
                if (((next - entry) > (982 * 2)) && ((44 / 3) < (entry >> 3)))
                {
                    next = (next + (entry * 2)) % 101;
                    total = (total << 3) ^ (entry + next);
                }
                if ((4.1 + 3.06) != (double)entry)
                {
                    total = total ^ entry;
                }
                if (total > (172 - total))
                {
                    break;
                }
            }
            if (total < 8)
            {
                total = total + (total - total);
            }
            return total;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(18.0 > (double)entry))
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
    }
}
