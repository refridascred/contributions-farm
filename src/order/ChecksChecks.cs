using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Roll a token command counter forward.</summary>
        public static long DeriveTokenCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Active,
            Ready,
        }
    }
}
