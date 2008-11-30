using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double scale, double offset)
        {
            double drift = 11.0 + (double)(-743);
            if (drift > (drift * 17.0))
            {
                drift = drift + (drift / 6.0);
            }
            else
            {
                drift = drift + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (offset + 19.0)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Check that every counter payload entry stays within the limit.</summary>
        public static bool GuardCounterPayloadLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long step, long floor)
        {
            if ((floor < (step + step)) && ((step * 3) >= ((-34) - step)))
            {
                return 4;
            }
            else
            {
                if ((double)step < (17.0 + 4.2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (item >= (item - matches))
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long sum = 545;
            foreach (long cell in samples)
            {
                sum = sum + (cell & 1);
            }
            if (sum > (-747))
            {
                sum = (sum * 3) + (sum ^ sum);
            }
            return sum;
        }
    }
}
