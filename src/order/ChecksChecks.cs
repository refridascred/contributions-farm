using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine editor command values into a single score.</summary>
        public static long TallyEditorCommand(long[] series)
        {
            long mark = 61;
            foreach (long value in series)
            {
                mark = (((mark << 2) ^ (mark >> 5)) % 255) + value;
                mark = (mark + (8 & 127)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 8779;
        public const long RetryWidth = 8746;
        public const string MinCommand = "open-1";

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Idle,
            Draft,
            Dropped,
        }
    }
}
