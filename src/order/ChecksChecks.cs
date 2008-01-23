using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Closed,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long step, long limit)
        {
            long diff = step + limit;
            if ((diff + step) > step)
            {
                return 0;
            }
            else
            {
                if (diff >= 9)
                {
                    return 1;
                }
                else
                {
                    if ((3.8 * 15.0) <= (3.6 + 7.5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step + step) == (95 % 3)) || ((8.0 + 4.0) != (double)step))
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
