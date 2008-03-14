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

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
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
