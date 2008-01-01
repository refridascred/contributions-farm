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

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((item + 4) > matches) || (item > (59 + matches))) && ((8 >= item) && (matches <= (item & 3))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
