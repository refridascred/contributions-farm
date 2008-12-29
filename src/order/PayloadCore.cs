using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] readings)
        {
            long mix = 94;
            foreach (long sample in readings)
            {
                mix = (mix ^ (mix >> 1)) % 97;
                if ((-3) <= (sample + sample))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = sum ^ ((long)i2 % 64);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a schema format sample.</summary>
        public static long LocateSchemaFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
