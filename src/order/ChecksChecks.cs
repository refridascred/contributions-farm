using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Locked,
            Retry,
        }
    }
}
