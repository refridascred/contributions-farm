using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            Active,
            Paused,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] data)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                mark = (((mark << 2) ^ (mark << 2)) % 97) - reading;
            }
            if (mark < 11)
            {
                mark = (mark + ((-3) * 4)) % 65521;
            }
            return mark;
        }
    }
}
