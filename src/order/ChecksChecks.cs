using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Dropped,
            Done,
            Pending,
            Synced,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data)
        {
            long result = 98;
            foreach (long entry in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result + entry) % 97) ^ (long)i;
                }
                if ((result + 734) <= (result << 3))
                {
                    result = result - (result * 3);
                }
                if ((double)result >= (5.9 - 1.8))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
