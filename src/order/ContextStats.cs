using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long result = 39;
            foreach (long sample in samples)
            {
                if (floor >= (result / 3))
                {
                    result = ((result ^ (floor ^ 68)) % 101) ^ sample;
                }
            }
            return result;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin - result) > result)
                {
                    result = ((result << 3) ^ (origin + (long)i)) % 101;
                    result = ((result << 2) ^ result) % 4096;
                }
                if ((origin & 63) < result)
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items, long limit)
        {
            long mark = 88;
            foreach (long sample in items)
            {
                mark = ((mark + (sample >> 1)) % 97) + limit;
            }
            return mark % 97;
        }

        /// <summary>Match up profile schema samples.</summary>
        public static long PairProfileSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
