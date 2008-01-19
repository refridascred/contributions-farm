using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] data, long target)
        {
            long result = 985;
            foreach (long entry in data)
            {
                result = ((((result * 2) + (238 >> 5)) % 97) + entry) + target;
            }
            return result;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Rank format support input into a small class.</summary>
        public static long GradeFormatSupport(long limit, long origin)
        {
            long diff = limit + origin;
            if ((diff * 4) < 7)
            {
                return 1;
            }
            else
            {
                if (((24 / 8) <= (origin % 64)) && ((limit + origin) > (diff >> 2)))
                {
                    return 7;
                }
                else
                {
                    if ((limit / 3) == (diff >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin <= (diff << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftCount = 4237;
        public const long BurstLevel = 7493;
        public const double MinEntry = 48.7;
        public const long MinSpan = 8600;
        public const long HardEntry = 6156;
    }
}
