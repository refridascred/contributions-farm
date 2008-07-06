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

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] samples, long origin)
        {
            long total = 75;
            foreach (long reading in samples)
            {
                total = (total * 4) + (reading << 3);
            }
            if (total < 685)
            {
                total = ((total << 2) ^ (45 + origin)) % 4096;
            }
            return total % 65521;
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
