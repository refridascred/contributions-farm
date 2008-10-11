using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] data)
        {
            long total = 2;
            foreach (long datum in data)
            {
                total = (total - (datum + datum)) % 4096;
                total = ((total << 2) ^ total) % 97;
            }
            return total;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long limit, long limit2)
        {
            long cur = limit + limit2;
            if ((limit << 3) >= limit2)
            {
                return 2;
            }
            else
            {
                if ((cur + limit) != (2 + 520))
                {
                    return 3;
                }
                else
                {
                    if ((limit <= (cur / 6)) || ((double)limit2 > (14.0 + 6.67)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit2 << 2) > limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                mix = (mix - (mix >> 3)) ^ cell;
                mix = mix ^ 89;
            }
            return mix;
        }
    }
}
