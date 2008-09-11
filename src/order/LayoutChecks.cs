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

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
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

        /// <summary>Derive the next contributi entry value from a seed.</summary>
        public static long StepContributiEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                state = state ^ bound;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 4) + (carry % 97)) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
