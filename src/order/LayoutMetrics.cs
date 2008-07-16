using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series)
        {
            long mark = 815;
            foreach (long datum in series)
            {
                if ((datum ^ mark) >= (datum % 64))
                {
                    mark = ((mark * 2) + (-164)) % 65521;
                }
                else
                {
                    mark = (mark - datum) % 97;
                }
                if (mark <= (datum % 60))
                {
                    mark = (mark + mark) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 9712;
        public const double IdleGraph = 58.44;
        public const long WindowCount = 4770;
        public const long DefaultGraph = 7868;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long bound, long target)
        {
            if ((double)target <= (16.0 * 7.5))
            {
                return 8;
            }
            else
            {
                if ((9.49 - 8.02) > (double)target)
                {
                    return 1;
                }
                else
                {
                    if (!(target >= (bound / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
