using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitCount = "primary-edge";
        public const long MaxCount = 2329;
        public const double CacheRatio = 6.39;

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double rate, double floor)
        {
            double mean = 7.52;
            if (mean < (rate + floor))
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean + (floor - mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 3.0) - (double)(long)i;
            }
            return mean - (double)2;
        }

        /// <summary>Look up the position of a cluster report sample.</summary>
        public static long LocateClusterReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count channel graph pairs that satisfy a relation.</summary>
        public static long OverlapChannelGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
