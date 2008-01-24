using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (result ^ step)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result - (step << 2)) % 101) - (long)i2;
                }
                if (279 >= ((long)i - step))
                {
                    result = (result + (step + (long)i)) % 1000;
                    result = ((result * 2) + ((long)i * 5)) % 255;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit format record readings against a rule.</summary>
        public static long TallyFormatRecordOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)count >= (6.8 + 17.0))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
