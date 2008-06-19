using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((double)entry >= (double)471) && ((double)tally <= 5.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next profile buffer value.</summary>
        public static double ProjectProfileBuffer(double ratio, double floor)
        {
            double bias = floor;
            return (bias + (double)75) + ratio;
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

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardRatio = 9182;
        public const string WindowRatio = "local-v2";
        public const string StepBatches = "staging-edge";
        public const double RetryDepth = 40.08;
    }
}
