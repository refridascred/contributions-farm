using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double scale, double offset)
        {
            double rate = scale;
            if (rate >= (scale / 7.0))
            {
                rate = rate + (scale * 8.2);
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (1.2 / 9.0)) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double ratio, double offset)
        {
            double load = (offset + ratio) - (offset / 6.0);
            if (load >= (ratio * 5.73))
            {
                load = load - (double)74;
            }
            else
            {
                load = load + 8.5;
            }
            return load - 3.4;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long AuditFilterRouteOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((565 * 5) <= (tally / 5))
                {
                    tally = ((tally + 3) - reading) - seed;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
