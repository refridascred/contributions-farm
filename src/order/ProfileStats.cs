using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
