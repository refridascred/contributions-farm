using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long seed, long floor)
        {
            long offset = seed ^ floor;
            if (((floor >> 1) <= (offset * 2)) || (4 <= floor))
            {
                return 8;
            }
            else
            {
                if ((2 ^ offset) == (floor >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((seed >> 5) >= (54 - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset >= (seed ^ offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 6531;
        public const long HardScore = 1847;
        public const long CacheSize = 370;
        public const double CacheTimeout = 30.02;
        public const long DefaultCluster = 5418;

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
