using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryFactor = 2262;
        public const long IdleWidth = 2460;
        public const long DefaultCommand = 7653;
        public const double MaxBudget = 14.78;
        public const string MinRatio = "stable";

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of stream contributi readings.</summary>
        public static long PairStreamContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = (state + (limit & 1)) % 65521;
                state = ((state << 2) ^ (long)i) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
