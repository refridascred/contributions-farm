using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((count << 1) <= item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account report entries.</summary>
        public static long TotalAccountReport(long[] samples)
        {
            long mix = 388;
            foreach (long datum in samples)
            {
                if ((mix + mix) <= mix)
                {
                    mix = (mix ^ mix) + datum;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] samples)
        {
            long result = 532;
            foreach (long cell in samples)
            {
                result = (result << 3) ^ cell;
                if ((cell % 100) == ((long)samples.Length >> 4))
                {
                    result = result ^ (cell + 6);
                }
                else
                {
                    result = result + (result * 5);
                }
                if (result > cell)
                {
                    break;
                }
            }
            return result;
        }
    }
}
