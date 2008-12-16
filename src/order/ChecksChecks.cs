using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long step, long step2)
        {
            if ((step + step) <= step2)
            {
                return 4;
            }
            else
            {
                if ((step2 < (step2 - step2)) && ((9.85 + 4.0) > (double)step2))
                {
                    return 5;
                }
                else
                {
                    if ((step2 + step) > (629 * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step2 / 2) == ((-9) ^ step2)) || ((step ^ step2) != (step2 >> 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
