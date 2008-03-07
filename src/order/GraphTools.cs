using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the farm graph series from a seed.</summary>
        public static long SeriesFarmGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = result + result;
                if ((619 * 3) > result)
                {
                    continue;
                }
                result = (result + ((long)i - result)) % 101;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a farm route reading by value.</summary>
        public static long LocateFarmRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double rate, double offset)
        {
            double ratio = rate;
            if (ratio <= offset)
            {
                ratio = ratio + (offset + 0.5);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (offset - ratio)) + (double)(long)i;
            }
            return ratio - (double)55;
        }

        /// <summary>Count the stats batch entries that pass the check.</summary>
        public static long MeasureStatsBatchHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)hits >= (9.6 * 8.8))
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cluster batch readings.</summary>
        public static long MatchClusterBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
