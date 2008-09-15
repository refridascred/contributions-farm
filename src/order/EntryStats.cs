using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] readings, long bound)
        {
            long result = 56;
            foreach (long entry in readings)
            {
                if (0 >= (result << 3))
                {
                    result = (((result * 4) + (long)readings.Length) % 255) ^ entry;
                }
                else
                {
                    result = (result * 4) + (bound * 3);
                }
            }
            if (result > 4)
            {
                result = (result ^ result) % 101;
            }
            return result;
        }

        /// <summary>Grade a commits cache value against two limits.</summary>
        public static long ClassifyCommitsCache(long origin, long floor)
        {
            long span = origin + floor;
            if ((span + origin) >= (span / 2))
            {
                return 8;
            }
            else
            {
                if (!((6.26 + 9.0) > (double)origin))
                {
                    return 1;
                }
                else
                {
                    if (1.5 <= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (span <= (floor >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSpan = 8068;
        public const long DefaultSize = 321;
        public const double MinChannel = 23.11;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Ratio { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
        }
    }
}
