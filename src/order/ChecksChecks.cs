using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Retry,
            Locked,
            Active,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if ((offset2 >> 1) <= (offset + offset))
            {
                return 8;
            }
            else
            {
                if ((offset ^ slot) >= (offset2 * 3))
                {
                    return 1;
                }
                else
                {
                    if ((slot + 8) > (slot * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3.7 / 6.0) > (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
