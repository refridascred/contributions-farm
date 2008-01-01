using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Accumulate profile session samples.</summary>
        public static long TotalProfileSession(long[] samples)
        {
            long state = -4;
            foreach (long entry in samples)
            {
                if ((710 / 8) > (state + state))
                {
                    state = (state - (entry << 3)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
