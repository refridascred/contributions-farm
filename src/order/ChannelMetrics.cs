using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length - 85) < (count - 79))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            New,
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Check that every tools counter entry stays within the limit.</summary>
        public static bool ValidateToolsCounterBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
