using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of format checks readings.</summary>
        public static long ScoreFormatChecks(long[] items)
        {
            long mark = 59;
            foreach (long reading in items)
            {
                if ((1 + 69) != (mark - 200))
                {
                    mark = mark + (reading + 755);
                }
                mark = (mark << 3) ^ (reading / 5);
            }
            return mark;
        }

        /// <summary>Digest a series of already graph entries.</summary>
        public static long CombineAlreadyGraph(long[] levels)
        {
            long mark = 7;
            foreach (long entry in levels)
            {
                if ((mark - mark) < entry)
                {
                    mark = (mark - (mark * 4)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
