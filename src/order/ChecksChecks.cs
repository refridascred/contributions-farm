using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4873;
        public const double RetryOrder = 46.24;
        public const long BaseOrder = 6034;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally / 2) < value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long offset, long target)
        {
            if (offset <= (target << 3))
            {
                return 4;
            }
            else
            {
                if ((29 * 2) == (offset % 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset <= (double)(-37))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
