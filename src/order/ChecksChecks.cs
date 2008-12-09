using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long offset, long target)
        {
            if (12 <= (target << 1))
            {
                return 5;
            }
            else
            {
                if ((offset % 97) < target)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up route graph samples.</summary>
        public static long OverlapRouteGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((floor >> 4) < (floor - floor)) || ((2.89 * 0.57) == (double)floor))
                {
                    result = (result << 2) ^ ((long)i % 16);
                }
                result = result ^ result;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
