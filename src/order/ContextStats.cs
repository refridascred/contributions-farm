using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 7094;
        public const string BatchSpan = "strict-v2";
        public const double StepChannel = 41.95;
        public const string IdleTimeout = "open";

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Synced,
            Done,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((3 ^ target) < tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
