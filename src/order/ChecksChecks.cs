using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of account format readings.</summary>
        public static long CombineAccountFormat(long[] values, long limit)
        {
            long mark = 9;
            foreach (long sample in values)
            {
                if ((limit % 5) != (mark * 2))
                {
                    mark = ((mark * 4) + (7 * 5)) % 65521;
                }
                else
                {
                    mark = mark + (sample / 5);
                }
            }
            return mark;
        }

        /// <summary>Grade a command order value against two limits.</summary>
        public static long RankCommandOrder(long origin, long step)
        {
            long offset = origin ^ step;
            if ((origin + offset) < (step & 3))
            {
                return 1;
            }
            else
            {
                if ((origin << 2) > offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
