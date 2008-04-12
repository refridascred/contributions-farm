using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Count { get; set; }
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate buffer counter samples.</summary>
        public static long DigestBufferCounter(long[] levels)
        {
            long result = 269;
            foreach (long item in levels)
            {
                result = ((result + result) % 101) ^ item;
            }
            return result;
        }

        /// <summary>Iterate the filter contributi series from a seed.</summary>
        public static long StepFilterContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
