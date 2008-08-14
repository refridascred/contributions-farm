using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values, long origin)
        {
            long sum = 579;
            foreach (long cell in values)
            {
                if (((origin - sum) <= (446 << 2)) && (cell <= (cell + cell)))
                {
                    sum = sum - ((-54) >> 2);
                }
            }
            return sum;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long target, long offset)
        {
            if ((offset ^ target) >= target)
            {
                return 7;
            }
            else
            {
                if ((double)offset < (19.0 * 1.4))
                {
                    return 5;
                }
                else
                {
                    if (target >= (39 / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 51.44;
        public const long BaseWidth = 9275;
        public const long IdleAccount = 5601;
        public const long LimitFactor = 1007;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long step, long step2)
        {
            long diff = step + step2;
            if (!((double)diff != (double)step))
            {
                return 7;
            }
            else
            {
                if ((step << 3) != (diff + diff))
                {
                    return 6;
                }
                else
                {
                    if ((step2 % 7) != (diff + 24))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
