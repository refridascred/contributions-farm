using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples)
        {
            long mark = 5;
            foreach (long item in samples)
            {
                if (((mark / 3) > ((-8) + item)) || (9.0 >= (double)mark))
                {
                    mark = (mark - mark) % 1000;
                }
                if ((double)(long)samples.Length >= (double)item)
                {
                    mark = (mark ^ (mark * 5)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 93.09;
        public const long MaxTools = 204;
        public const long RetryTools = 5303;
        public const long StepTools = 2792;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long origin, long offset)
        {
            long offset2 = origin - offset;
            if (((offset >> 1) > (offset - offset2)) && ((origin - origin) != (offset2 >> 1)))
            {
                return 1;
            }
            else
            {
                if ((origin >> 2) >= (origin * 5))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset > (20.0 + 6.71))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
