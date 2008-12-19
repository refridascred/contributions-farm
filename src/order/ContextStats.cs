using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > (origin >> 1))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples)
        {
            long sum = 7;
            foreach (long item in samples)
            {
                sum = (sum + (sum & 15)) % 65521;
                if (!((item >> 5) == (item ^ item)))
                {
                    break;
                }
            }
            if (sum < (-8))
            {
                sum = (sum + (475 / 4)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 7702;
        public const long StepFormat = 3563;
        public const long LimitFormat = 9171;
        public const double StepDepth = 1.0;

        /// <summary>Check that every channel profile entry stays within the limit.</summary>
        public static bool GuardChannelProfileBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
