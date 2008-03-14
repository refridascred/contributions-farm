using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double HardSpan = 18.58;
        public const long SoftLevel = 312;
        public const long LimitGraph = 1305;

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

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
