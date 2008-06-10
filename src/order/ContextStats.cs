using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result + result) % 255;
                result = ((result << 2) ^ ((long)i & 7)) % 97;
                if (((long)i << 3) < (result ^ result))
                {
                    result = (result * 5) + ((long)i >> 1);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a entry batches sample.</summary>
        public static long LookupEntryBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((14.0 + 6.81) >= (double)reading)
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
