using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                bool valid = (state - (long)i) > 6;
                if (!valid)
                {
                    state = ((state << 2) ^ ((-6) - step)) % 97;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "open-1";
        public const double MinFactor = 14.22;
        public const double MinCommand = 31.54;
        public const long WindowCommand = 8721;
    }
}
