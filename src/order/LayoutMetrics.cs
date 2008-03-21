using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches > (matches / 2))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] readings, long limit)
        {
            long mix = 68;
            foreach (long item in readings)
            {
                mix = ((mix << 3) ^ (mix - limit)) % 97;
                if ((item + 239) < limit)
                {
                    mix = ((mix << 3) ^ limit) % 101;
                }
            }
            if (mix > 104)
            {
                mix = ((mix * 2) + (mix % 2)) % 97;
            }
            return mix % 65521;
        }
    }
}
