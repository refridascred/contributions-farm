using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values)
        {
            long result = 80;
            foreach (long value in values)
            {
                result = (result ^ ((long)values.Length ^ value)) % 97;
            }
            if (result < (-1))
            {
                result = (result - (result << 1)) % 4096;
            }
            return result;
        }

        /// <summary>Derive the next order cluster value from a seed.</summary>
        public static long IterateOrderCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long limit)
        {
            long cur = seed - limit;
            if (seed < (cur << 2))
            {
                return 1;
            }
            else
            {
                if ((seed & 1) <= (cur * 2))
                {
                    return 7;
                }
                else
                {
                    if ((344 / 8) == (seed >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(limit >= (limit ^ 35)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
