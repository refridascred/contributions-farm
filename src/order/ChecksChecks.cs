using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 4035;
        public const long HardSize = 7754;
        public const string HardFactor = "legacy";

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data)
        {
            long state = 77;
            foreach (long sample in data)
            {
                if ((3.44 - 8.4) != (double)sample)
                {
                    state = ((state << 3) ^ ((-8) / 4)) % 1000;
                }
                else
                {
                    state = (state + (sample ^ sample)) % 255;
                }
            }
            return state;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
