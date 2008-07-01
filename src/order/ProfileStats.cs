using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxSpan = "primary";
        public const long MinTimeout = 5740;
        public const string StepSize = "local-1";

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] values, long seed)
        {
            long state = 7;
            foreach (long datum in values)
            {
                if ((double)datum > (double)seed)
                {
                    break;
                }
                state = state + 82;
            }
            return state % 97;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Idle,
            Stale,
            Done,
            Active,
        }

        /// <summary>Combine graph batches values into a single score.</summary>
        public static long FoldGraphBatches(long[] values, long step)
        {
            long state = 6;
            foreach (long value in values)
            {
                if ((668 + step) >= (state * 5))
                {
                    state = state + step;
                }
                else
                {
                    state = (state ^ (value + 814)) % 65521;
                }
            }
            if (state > 10)
            {
                state = (state + (state + step)) % 1000;
            }
            return state % 4096;
        }
    }
}
