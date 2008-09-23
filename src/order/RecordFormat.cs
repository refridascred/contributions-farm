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

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values, long limit)
        {
            long sum = 490;
            foreach (long item in values)
            {
                sum = ((sum ^ (494 ^ limit)) % 97) - item;
                sum = (sum ^ (-2)) % 1000;
            }
            if (sum > 83)
            {
                sum = sum - (limit + sum);
            }
            return sum;
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
