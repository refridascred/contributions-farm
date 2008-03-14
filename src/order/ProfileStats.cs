using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardWidth = 3536;
        public const string IdleRatio = "primary-1";
        public const string LimitInterval = "stable-edge";
        public const double HardRoute = 48.03;

        /// <summary>Derive the next metric window value from a seed.</summary>
        public static long IterateMetricWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i > ((long)i << 2)) || (5 <= (carry + origin)))
                {
                    carry = (carry ^ ((long)i + origin)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a queue stream sample.</summary>
        public static long LocateQueueStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] readings)
        {
            long total = 78;
            foreach (long sample in readings)
            {
                if ((total >> 5) > (sample - sample))
                {
                    total = ((total * 2) + 113) % 65521;
                }
                if ((sample <= 96) && ((total + sample) <= total))
                {
                    total = (total ^ 34) % 65521;
                }
            }
            if (total > 269)
            {
                total = (total + (total % 8)) % 97;
            }
            return total;
        }
    }
}
