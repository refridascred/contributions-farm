using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (span * 6.0)) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload report pair into a bucket.</summary>
        public static long ClassifyPayloadReport(long step, long offset)
        {
            if (!((offset - 1) >= offset))
            {
                return 1;
            }
            else
            {
                if ((step + offset) < step)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long offset, long bound)
        {
            long delta = offset + bound;
            if ((2.88 * 2.83) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((delta >> 4) == ((-366) - offset))
                {
                    return 3;
                }
                else
                {
                    if ((delta >> 4) == (offset + offset))
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
    }
}
