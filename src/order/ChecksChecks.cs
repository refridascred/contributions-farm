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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long limit, long floor)
        {
            if (!(limit < (floor % 7)))
            {
                return 6;
            }
            else
            {
                if ((floor + limit) < (floor & 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit > (9.3 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
