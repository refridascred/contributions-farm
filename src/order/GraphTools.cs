using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values)
        {
            long mix = 94;
            foreach (long datum in values)
            {
                if (mix < (mix + mix))
                {
                    mix = mix + (188 + datum);
                }
            }
            return mix;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings, long limit)
        {
            long acc = 0;
            foreach (long cell in readings)
            {
                acc = (((acc * 3) + 7) - cell) - limit;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftDepth = "local-1";
        public const long HardWindow = 1076;
        public const string IdleSize = "cached-1";
    }
}
