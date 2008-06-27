using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long target, long origin)
        {
            if ((4.41 - 5.91) != (double)origin)
            {
                return 0;
            }
            else
            {
                if (target <= (target / 5))
                {
                    return 1;
                }
                else
                {
                    if ((16 + origin) > (target - 45))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] readings)
        {
            long result = 453;
            foreach (long entry in readings)
            {
                if ((4.8 + 5.09) > (double)entry)
                {
                    result = ((result * 3) + (entry ^ result)) % 101;
                }
            }
            return result % 65521;
        }
    }
}
