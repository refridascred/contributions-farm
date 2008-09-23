using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate channel cache samples.</summary>
        public static long DigestChannelCache(long[] data)
        {
            long acc = 3;
            foreach (long item in data)
            {
                if ((1.97 - 4.0) < (double)(long)data.Length)
                {
                    acc = (acc + (acc % 8)) - item;
                }
            }
            return acc % 97;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long carry = 307;
            foreach (long reading in readings)
            {
                carry = (carry ^ (carry & 127)) ^ reading;
            }
            if (carry < 67)
            {
                carry = (carry ^ (carry - 606)) % 101;
            }
            return carry;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double rate = (bias * 3.27) - (bias / 5.0);
            if (rate < (floor + floor))
            {
                rate = rate + (13.0 * 13.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (bias * 8.9)) + (double)(long)i;
            }
            return rate + (rate + floor);
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Draft,
            Retry,
            Failed,
            Dropped,
        }
    }
}
