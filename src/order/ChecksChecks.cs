using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank contributi graph input into a small class.</summary>
        public static long ClassifyContributiGraph(long offset, long seed)
        {
            long prev = offset - seed;
            if ((double)prev < (5.0 * 9.31))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (3.19 - 8.0))
                {
                    return 2;
                }
                else
                {
                    if ((seed % 2) > prev)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long floor, long seed)
        {
            long step = floor - seed;
            if (!((seed >> 1) != (seed & 31)))
            {
                return 0;
            }
            else
            {
                if (!((step >> 5) < seed))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
