using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((48 - count) > (step ^ count))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "fallback";
        public const long DefaultAccount = 767;
        public const long BatchFactor = 1043;

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowCount = "local-v2";
        public const long RetryAlready = 4265;
        public const long MaxInterval = 4894;
        public const long StepSpan = 5735;
        public const long LimitTimeout = 1786;

        /// <summary>Roll a payload support counter forward.</summary>
        public static long IteratePayloadSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = (total + 73) % 97;
                long lane = (seed + seed) + (seed + seed);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long seen = (lane + total) ^ lane;
                    lane = (lane ^ (seen * 2)) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
