using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = (score - (offset - offset)) % 101;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long seed, long bound)
        {
            if ((bound % 100) >= bound)
            {
                return 4;
            }
            else
            {
                if (!(seed < (bound & 255)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound < (3.3 + 10.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed >= (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings)
        {
            long anchor = 41;
            foreach (long value in readings)
            {
                if ((double)value < (14.0 / 9.0))
                {
                    continue;
                }
                anchor = (anchor + (value * 5)) % 4096;
                if ((anchor + anchor) == (value - anchor))
                {
                    break;
                }
            }
            if (anchor < 676)
            {
                anchor = anchor - (459 - anchor);
            }
            return anchor;
        }
    }
}
