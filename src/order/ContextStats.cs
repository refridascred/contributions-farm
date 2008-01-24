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

        /// <summary>Rank counter token input into a small class.</summary>
        public static long GradeCounterToken(long origin, long target)
        {
            if (target > (origin ^ origin))
            {
                return 7;
            }
            else
            {
                if ((origin * 2) >= origin)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
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
