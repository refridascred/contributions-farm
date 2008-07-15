using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two graph entry measurements.</summary>
        public static double SmoothGraphEntry(double gain, double bias)
        {
            double mean = (double)(-16) * 3.0;
            if (mean >= mean)
            {
                mean = mean + (mean + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (gain * 9.14)) - (double)(long)i;
            }
            return mean - (double)10;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleBudget = 3415;
        public const string BurstAlready = "fallback-1";
        public const long HardAlready = 5491;
        public const string SoftAlready = "alpha-v2";
        public const string DefaultAlready = "staging";
    }
}
