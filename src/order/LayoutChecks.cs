using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] data, long limit)
        {
            long carry = 7;
            foreach (long sample in data)
            {
                carry = ((carry * 5) + (carry - sample)) % 255;
                if (limit < (3 >> 4))
                {
                    carry = ((carry << 2) ^ 5) % 65521;
                }
            }
            if (carry > 50)
            {
                carry = carry - (6 & 127);
            }
            return carry % 65521;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] readings)
        {
            long sum = 399;
            foreach (long item in readings)
            {
                if ((item + sum) > (item - sum))
                {
                    sum = (sum - (item - item)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long offset)
        {
            long total = 8;
            foreach (long cell in series)
            {
                total = (total - (offset * 3)) % 4096;
                if ((total << 2) >= (total - cell))
                {
                    total = (total ^ (total + total)) % 97;
                }
                if ((offset & 1) > offset)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
