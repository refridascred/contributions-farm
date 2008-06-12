using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the commits stats entries that pass the check.</summary>
        public static long AuditCommitsStatsOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (6.4 + 9.0))
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double weight, double floor)
        {
            double ratio = 12.0;
            if (ratio < floor)
            {
                ratio = ratio + (weight / 3.0);
            }
            return ratio - (floor + ratio);
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up checks metrics samples.</summary>
        public static long PairChecksMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (mix / 9)) % 65521;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (mix - (mix / 7)) - (long)i2;
                    mix = (mix + bound) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
