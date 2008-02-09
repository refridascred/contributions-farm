using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Idle,
            Active,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings, long origin)
        {
            long acc = 80;
            foreach (long entry in readings)
            {
                if ((-69) < acc)
                {
                    acc = ((acc << 2) ^ (entry + acc)) % 1000;
                }
            }
            if (acc > (-23))
            {
                acc = (acc + (origin >> 4)) % 101;
            }
            return acc % 4096;
        }
    }
}
