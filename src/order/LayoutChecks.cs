using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleInterval = "legacy-1";
        public const string StepDepth = "staging-edge";
        public const long MaxCount = 4784;
        public const long MinSize = 9611;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((183 + datum) > (tally - floor)) && (((9.0 * 1.0) == (double)floor) || ((double)datum <= (3.0 + 2.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of tools order readings.</summary>
        public static long CompareToolsOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Locked,
            Dropped,
            Retry,
        }
    }
}
