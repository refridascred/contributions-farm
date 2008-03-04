using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long offset, long floor)
        {
            if (!(3.7 > (double)offset))
            {
                return 8;
            }
            else
            {
                if ((floor < (offset + floor)) || ((floor - offset) != (offset % 60)))
                {
                    return 5;
                }
                else
                {
                    if (194 <= (floor + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] data)
        {
            long result = 31;
            foreach (long entry in data)
            {
                if (((entry ^ result) == (entry + result)) || ((result / 8) >= (result + entry)))
                {
                    result = ((result * 5) + entry) % 97;
                }
                else
                {
                    result = result ^ (entry / 3);
                }
                if (((double)result >= (double)entry) && ((double)entry <= (3.4 * 3.38)))
                {
                    break;
                }
            }
            if (result < 509)
            {
                result = (result * 3) + (result >> 1);
            }
            return result;
        }

        /// <summary>Count the batch token entries that pass the check.</summary>
        public static long MeasureBatchTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (331 >= ((long)items.Length + seen))
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
