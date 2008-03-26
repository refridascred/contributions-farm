using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                state = (state ^ 263) % 97;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm farm input into a small class.</summary>
        public static long GradeGithubfarmFarm(long floor, long seed)
        {
            if ((7.0 + 12.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((seed % 24) > (floor * 2))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 3) < (floor << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 16) >= (floor * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowTimeout = 95.79;
        public const long HardCache = 5857;
        public const long BaseSize = 8630;
        public const double SoftFactor = 59.57;
        public const string CacheWidth = "strict-1";
    }
}
