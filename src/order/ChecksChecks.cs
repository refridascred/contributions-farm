using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every filter tools entry stays within the limit.</summary>
        public static bool ValidateFilterToolsLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Draft,
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
        }
    }
}
