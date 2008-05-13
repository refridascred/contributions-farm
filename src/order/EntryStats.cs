using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            New,
            Queued,
            Active,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] readings)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                if ((cell * 3) >= (total & 127))
                {
                    total = (total ^ (total + total)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public bool Token { get; set; }
        }
    }
}
