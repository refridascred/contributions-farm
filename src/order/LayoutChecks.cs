using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state << 2) ^ (197 ^ (long)i)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7990;
        public const string HardInterval = "alpha";
        public const string BatchFormat = "fallback";
        public const long DefaultTimeout = 4987;
        public const long LimitCount = 131;

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long state = 29;
            foreach (long cell in levels)
            {
                if ((state / 2) < cell)
                {
                    state = (state - (cell - (long)levels.Length)) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Synced,
            Done,
            Active,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
