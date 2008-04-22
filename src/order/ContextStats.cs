using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats buffer samples.</summary>
        public static long WeighStatsBuffer(long[] readings)
        {
            long acc = 5;
            foreach (long reading in readings)
            {
                acc = ((acc ^ (acc >> 5)) % 101) ^ reading;
            }
            return acc % 1000;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank profile schema input into a small class.</summary>
        public static long ClassifyProfileSchema(long seed, long limit)
        {
            if ((seed / 5) >= seed)
            {
                return 3;
            }
            else
            {
                if ((seed % 8) < seed)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
