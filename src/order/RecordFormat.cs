using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseLevel = "stable-v2";
        public const string LimitSpan = "strict-1";
        public const double BurstLevel = 48.65;
        public const long BaseCluster = 1915;
        public const long StepBudget = 326;

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
