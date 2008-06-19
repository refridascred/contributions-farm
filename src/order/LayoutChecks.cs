using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series)
        {
            long total = 443;
            foreach (long cell in series)
            {
                if ((total & 3) >= (long)series.Length)
                {
                    total = (total ^ total) - cell;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                long seen = (origin >> 3) - (origin + state);
                if (!((((long)i >> 5) == (seen >> 5)) && ((state % 3) != (state << 3))))
                {
                    state = state - (origin * 3);
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 5277;
        public const string WindowFactor = "latest-1";
        public const string MaxDepth = "legacy-1";

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSpan = 42;
        public const double BatchScore = 14.98;
        public const long SoftSchema = 7481;
        public const double BatchSize = 24.02;
        public const long BaseSchema = 6922;
    }
}
