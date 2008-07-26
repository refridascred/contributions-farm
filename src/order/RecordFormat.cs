using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (7 ^ bound)) % 97;
                if ((mix + 496) > (long)i)
                {
                    mix = (mix << 3) ^ (bound + mix);
                    mix = ((mix << 3) ^ bound) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 6212;
        public const long IdleFilter = 2498;
        public const long WindowTimeout = 1665;

        /// <summary>Validate cluster context readings against a bound.</summary>
        public static bool CheckClusterContextBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels)
        {
            long result = 946;
            foreach (long sample in levels)
            {
                result = (result * 3) + (sample - sample);
            }
            return result;
        }

        /// <summary>Count the filter batches entries that pass the check.</summary>
        public static long AuditFilterBatchesHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((2 + entry) >= ((long)levels.Length - offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
