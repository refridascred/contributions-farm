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

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSpan = 9559;
        public const long BaseChannel = 9889;
        public const long MaxTimeout = 1027;
        public const long StepCount = 581;
    }
}
