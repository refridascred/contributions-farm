using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double rate, double floor)
        {
            double load = (double)((-625) + 3);
            if (load >= (double)60)
            {
                load = (load - load) - rate;
            }
            else
            {
                load = load + 1.85;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (floor * 13.0)) + (double)(long)i;
            }
            return load - 7.1;
        }

        /// <summary>Compare every pair of buffer queue readings.</summary>
        public static long OverlapBufferQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long limit, long target)
        {
            if ((limit * 4) >= limit)
            {
                return 6;
            }
            else
            {
                if ((limit % 97) != (target / 6))
                {
                    return 2;
                }
                else
                {
                    if (!((441 * 2) >= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((4.7 + 8.6) == (double)limit) || ((limit & 63) <= (target / 5)))
                        {
                            return 7;
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
