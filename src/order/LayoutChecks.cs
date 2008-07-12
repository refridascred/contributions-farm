using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first schema report entry that matches the target.</summary>
        public static long LocateSchemaReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long offset)
        {
            long diff = bound - offset;
            if (!(offset > (17 - offset)))
            {
                return 7;
            }
            else
            {
                if (!((double)diff > (7.59 + 2.68)))
                {
                    return 0;
                }
                else
                {
                    if (((double)bound <= (double)(-73)) && (37 >= offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((count / 6) <= cell))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph route samples are out of range.</summary>
        public static long TallyGraphRouteOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (double)11)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
