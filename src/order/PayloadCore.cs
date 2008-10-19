using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Stale,
            Pending,
            Dropped,
            New,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
