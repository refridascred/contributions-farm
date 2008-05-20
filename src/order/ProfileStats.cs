using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Active,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Paused,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = result ^ (result & 3);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
