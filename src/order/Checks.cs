using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every window command entry stays within the limit.</summary>
        public static bool VerifyWindowCommandBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
