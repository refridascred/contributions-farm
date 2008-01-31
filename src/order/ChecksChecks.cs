using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a graph account counter forward.</summary>
        public static long RollGraphAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ (long)i;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            Queued,
            Idle,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowWidth = "strict-edge";
        public const long StepCount = 2358;
        public const long SoftFactor = 9409;
    }
}
