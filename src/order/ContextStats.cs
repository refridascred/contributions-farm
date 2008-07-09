using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string WindowDepth = "alpha-v2";
        public const long RetryReport = 2565;
        public const string MaxReport = "staging";

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long origin, long seed)
        {
            long next = origin - seed;
            if ((origin + seed) < seed)
            {
                return 0;
            }
            else
            {
                if (((double)next > (double)767) || ((origin ^ next) < seed))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 3) < next)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed + origin) >= ((-6) % 12)) && ((origin & 31) == (97 - next)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((step / 4) > (seen + seen))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
