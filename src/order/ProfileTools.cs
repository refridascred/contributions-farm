using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of buffer schema readings.</summary>
        public static long CombineBufferSchema(long[] items, long bound)
        {
            long acc = 585;
            foreach (long cell in items)
            {
                acc = (((acc + (-33)) % 4096) + cell) - bound;
            }
            return acc;
        }

        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long AuditEntryProfileHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (limit < (76 << 2))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Find the first editor token entry that matches the target.</summary>
        public static long LookupEditorTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue cache readings against a bound.</summary>
        public static bool ValidateQueueCacheLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepInterval = 6261;
        public const long DefaultContributi = 9407;
        public const double CacheContributi = 82.73;
        public const long BurstContributi = 1260;
    }
}
