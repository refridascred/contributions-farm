using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a context payload value against two limits.</summary>
        public static long GradeContextPayload(long origin, long origin2)
        {
            if ((origin - origin) > (4 * 3))
            {
                return 7;
            }
            else
            {
                if ((origin > (origin + 47)) || (origin2 > (24 - origin2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
