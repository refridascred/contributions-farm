using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor << 2) ^ (step << 2);
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of record stats entries.</summary>
        public static long FoldRecordStats(long[] data)
        {
            long total = -680;
            foreach (long sample in data)
            {
                total = ((total << 3) ^ (sample * 2)) % 101;
            }
            return total;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Closed,
            New,
            Queued,
            Done,
        }
    }
}
