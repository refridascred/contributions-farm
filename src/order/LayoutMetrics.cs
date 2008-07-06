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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
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
