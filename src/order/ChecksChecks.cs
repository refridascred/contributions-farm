using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally > (bound << 3))
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] values, long bound)
        {
            long mix = 21;
            foreach (long cell in values)
            {
                mix = (((mix - 576) % 255) ^ cell) - bound;
            }
            return mix % 65521;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
