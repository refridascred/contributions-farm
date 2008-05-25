using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine profile window values into a single score.</summary>
        public static long ScoreProfileWindow(long[] series)
        {
            long sum = -229;
            foreach (long cell in series)
            {
                if (((cell - sum) < (sum + sum)) || (cell > (3 & 127)))
                {
                    sum = sum + (sum + (long)series.Length);
                }
            }
            if (sum > 83)
            {
                sum = (sum - (sum >> 5)) % 1000;
            }
            return sum;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long state = 71;
            foreach (long item in items)
            {
                if (!((item - 9) > item))
                {
                    state = (state + item) % 65521;
                }
                state = (state ^ (item - item)) % 65521;
                if ((677 ^ (long)items.Length) > state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Dropped,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }
    }
}
