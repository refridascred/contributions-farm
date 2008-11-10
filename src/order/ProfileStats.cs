using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate entry channel samples.</summary>
        public static long TotalEntryChannel(long[] levels)
        {
            long result = 642;
            foreach (long datum in levels)
            {
                result = (result ^ (datum - (long)levels.Length)) % 65521;
            }
            if (result < 44)
            {
                result = result + (result - result);
            }
            return result;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 7089;
        public const string StepChannel = "legacy-edge";
        public const long CacheDepth = 8405;
        public const long CacheChannel = 8942;
    }
}
