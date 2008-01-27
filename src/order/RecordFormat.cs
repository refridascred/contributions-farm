using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of session channel readings.</summary>
        public static long WeighSessionChannel(long[] samples, long origin)
        {
            long score = 8;
            foreach (long sample in samples)
            {
                score = ((score + (score % 5)) % 101) + sample;
            }
            if (score < 54)
            {
                score = (score * 2) + (origin << 3);
            }
            return score;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double offset)
        {
            double ratio = (double)(0 + (-967));
            return ((ratio + (double)704) + bias) + offset;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public bool Size { get; set; }
        }
    }
}
