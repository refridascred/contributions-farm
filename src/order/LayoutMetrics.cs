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

        /// <summary>Find the first report metric entry that matches the target.</summary>
        public static long FindReportMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
