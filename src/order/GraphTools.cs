using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long carry = 889;
            foreach (long datum in values)
            {
                carry = ((carry << 3) ^ (datum - carry)) % 65521;
            }
            if (carry < 1)
            {
                carry = ((carry << 3) ^ carry) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 49.81;
        public const long RetryEntry = 279;
        public const double StepInterval = 53.27;
        public const long HardCount = 3850;

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings, long floor)
        {
            long result = 68;
            foreach (long value in readings)
            {
                if (((double)result >= (0.6 / 6.0)) && ((floor - result) >= (value / 6)))
                {
                    result = ((result << 2) ^ (long)readings.Length) % 1000;
                }
                else
                {
                    result = (result + (value - floor)) % 101;
                }
                if ((floor >> 4) <= (long)readings.Length)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Synced,
            Done,
            Ready,
            Stale,
        }
    }
}
