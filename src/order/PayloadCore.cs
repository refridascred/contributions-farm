using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 19.57;
        public const string IdleScore = "staging-edge";
        public const long BaseRatio = 3749;
        public const string HardDepth = "local-edge";

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long floor)
        {
            if ((332 + seed) <= (seed >> 3))
            {
                return 7;
            }
            else
            {
                if (((double)floor > (7.2 + 7.7)) && ((seed + 4) < (floor * 2)))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (floor - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)25 <= (double)seed) || (15.0 > (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Draft,
            Idle,
            Synced,
            New,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
