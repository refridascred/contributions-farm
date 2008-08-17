using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 3) ^ (bound & 127)) % 101;
                score = (score << 2) ^ ((long)i ^ (long)i);
                if (!(((1 - bound) == (long)i) || ((bound * 5) <= (score + (long)i))))
                {
                    score = (score - (score * 5)) % 1000;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
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
