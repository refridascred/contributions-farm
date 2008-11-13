using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Paused,
            New,
            Done,
            Locked,
        }

        /// <summary>Combine counter buffer values into a single score.</summary>
        public static long ScoreCounterBuffer(long[] series)
        {
            long sum = 551;
            foreach (long sample in series)
            {
                if (((long)series.Length + sum) <= (sample & 1))
                {
                    sum = sum + (sample >> 5);
                }
            }
            return sum;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Total { get; set; }
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
