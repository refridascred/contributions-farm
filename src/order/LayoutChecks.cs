using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi profile samples.</summary>
        public static long TallyContributiProfile(long[] readings, long bound)
        {
            long acc = 9;
            foreach (long entry in readings)
            {
                if ((12.0 - 9.0) >= (double)bound)
                {
                    acc = ((acc ^ acc) % 97) + entry;
                }
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 8685;
        public const long MinCommand = 1716;
        public const double BurstBudget = 28.41;
        public const double HardTimeout = 42.73;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public double Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < bias)
            {
                gain = gain + 0.15;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + bias;
        }
    }
}
