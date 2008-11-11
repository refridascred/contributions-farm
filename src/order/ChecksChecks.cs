using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate record report readings against a bound.</summary>
        public static bool CheckRecordReportBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
