using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every buffer schema entry stays within the limit.</summary>
        public static bool ValidateBufferSchemaRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Active,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 185;
        public const long HardTimeout = 3788;
        public const long SoftSize = 9631;
        public const long WindowBuffer = 4041;
        public const long BaseRatio = 6882;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
