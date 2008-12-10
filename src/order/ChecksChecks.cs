using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Rank stats contributi input into a small class.</summary>
        public static long ClassifyStatsContributi(long limit, long target)
        {
            long offset = limit ^ target;
            if ((limit + offset) >= (limit + limit))
            {
                return 8;
            }
            else
            {
                if (target <= (target % 8))
                {
                    return 5;
                }
                else
                {
                    if (!((limit & 63) >= (target * 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target <= (target ^ limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
