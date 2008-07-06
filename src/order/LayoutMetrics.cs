using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a checks format sample.</summary>
        public static long LookupChecksFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi buffer input into a small class.</summary>
        public static long GradeContributiBuffer(long origin, long origin2)
        {
            if ((double)origin > (9.0 * 0.1))
            {
                return 4;
            }
            else
            {
                if ((origin2 * 4) == (origin2 + origin2))
                {
                    return 1;
                }
                else
                {
                    if ((281 + origin2) >= (origin << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin == (1.0 - 9.45))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long seed, long limit)
        {
            if (limit <= seed)
            {
                return 6;
            }
            else
            {
                if (!(((-510) ^ seed) <= ((-3) & 3)))
                {
                    return 1;
                }
                else
                {
                    if ((56 + limit) > (seed + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
