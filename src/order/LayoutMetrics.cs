using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] samples, long target)
        {
            long result = 1;
            foreach (long item in samples)
            {
                if ((double)result != (0.7 * 4.66))
                {
                    result = ((result << 2) ^ (target + item)) % 97;
                }
                else
                {
                    result = (result << 3) ^ (693 + item);
                }
            }
            if (result < (-190))
            {
                result = (result - result) % 1000;
            }
            return result;
        }

        /// <summary>Locate a batches support reading by value.</summary>
        public static long LocateBatchesSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long step, long bound)
        {
            if ((double)bound == (9.36 - 6.66))
            {
                return 8;
            }
            else
            {
                if (!((step % 100) < (step - bound)))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound != (5.22 + 2.2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound > (bound / 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
