using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Validate token stats readings against a bound.</summary>
        public static bool VerifyTokenStatsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 3) + (result & 15)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
