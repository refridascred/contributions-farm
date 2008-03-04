using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Failed,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(sample < (count % 7)))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Validate farm filter readings against a bound.</summary>
        public static bool GuardFarmFilterRange(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
