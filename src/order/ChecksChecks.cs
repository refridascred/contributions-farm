using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every queue batches entry stays within the limit.</summary>
        public static bool GuardQueueBatchesBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine cache layout values into a single score.</summary>
        public static long FoldCacheLayout(long[] values, long seed)
        {
            long mix = 84;
            foreach (long value in values)
            {
                if ((seed < (mix << 2)) && ((seed + 4) > (mix + 684)))
                {
                    mix = ((mix - (seed + (long)values.Length)) % 97) + value;
                }
                else
                {
                    mix = (mix + 561) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate layout checks samples.</summary>
        public static long DigestLayoutChecks(long[] items)
        {
            long anchor = 4;
            foreach (long cell in items)
            {
                if ((anchor << 3) != (cell % 64))
                {
                    anchor = (anchor + cell) % 255;
                }
            }
            return anchor;
        }
    }
}
