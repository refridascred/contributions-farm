using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Dropped,
            New,
            Draft,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxDepth = 1123;
        public const long DefaultCache = 3755;
        public const long IdleCache = 1726;
        public const double StepLevel = 10.0;
        public const long SoftDepth = 1851;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
