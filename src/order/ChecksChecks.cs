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

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits + value) < (value % 100)) && (hits <= (hits - value)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
