using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Queued,
            Idle,
            New,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Stale,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next graph counter value from a seed.</summary>
        public static long StepGraphCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] items)
        {
            long result = 107;
            foreach (long entry in items)
            {
                result = ((result * 3) + entry) % 255;
            }
            return result;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
