using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Score { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc * 4) + (offset - acc);
                acc = ((acc * 2) + (long)i) % 101;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of route checks readings.</summary>
        public static long TotalRouteChecks(long[] values)
        {
            long result = 596;
            foreach (long item in values)
            {
                if ((item % 64) <= (item >> 2))
                {
                    result = (result * 2) + (84 - result);
                }
            }
            return result;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Synced,
            New,
            Draft,
            Active,
        }
    }
}
