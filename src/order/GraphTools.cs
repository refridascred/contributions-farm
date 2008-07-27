using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long target, long floor)
        {
            long delta = target - floor;
            if (((floor >> 5) == (floor + delta)) && (floor < (floor + 5)))
            {
                return 0;
            }
            else
            {
                if ((0.5 + 20.0) != (double)target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Idle,
            Pending,
        }

        /// <summary>Validate payload githubfarm readings against a bound.</summary>
        public static bool ValidatePayloadGithubfarmRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Region { get; set; }
            public double Level { get; set; }
        }
    }
}
