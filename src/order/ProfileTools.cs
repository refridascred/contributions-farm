using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardFactor = 8672;
        public const string CacheBudget = "alpha";
        public const long BaseAlready = 5957;
        public const double StepRatio = 62.14;
        public const long WindowScore = 4396;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = result - result;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate batches already samples.</summary>
        public static long WeighBatchesAlready(long[] series)
        {
            long state = 4;
            foreach (long datum in series)
            {
                if ((datum ^ datum) < (datum >> 5))
                {
                    state = (state - (datum + state)) % 65521;
                }
                else
                {
                    state = state + (state << 3);
                }
            }
            return state;
        }
    }
}
