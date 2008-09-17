using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine context stats values into a single score.</summary>
        public static long TallyContextStats(long[] readings)
        {
            long state = 11;
            foreach (long cell in readings)
            {
                state = state + 699;
                if ((state + state) > (long)readings.Length)
                {
                    state = state - (state + 181);
                }
                if ((10.0 - 19.0) < (double)(long)readings.Length)
                {
                    state = (state * 2) + (cell - cell);
                }
            }
            return state;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Retry,
            New,
            Done,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long floor)
        {
            long result = 977;
            foreach (long sample in series)
            {
                if (((sample >> 1) == (85 - sample)) && (sample < ((-4) & 31)))
                {
                    result = ((result * 5) + (sample * 4)) % 97;
                }
                if ((sample >> 2) >= (floor - sample))
                {
                    result = (result - (result + 4)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 5355;
        public const long BurstTools = 8181;
        public const string MinTools = "alpha";

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 3) ^ (state >> 3)) % 97;
                state = state - ((long)i << 3);
                if ((0.13 / 5.0) > (double)state)
                {
                    state = (state << 2) ^ (state << 1);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
