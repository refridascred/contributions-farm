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

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Active,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepScore = 53.82;
        public const long BatchScore = 1971;
        public const string DefaultInterval = "local";

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
