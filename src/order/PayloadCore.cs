using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] values)
        {
            long result = 4;
            foreach (long sample in values)
            {
                if (!((sample >> 3) > (result + result)))
                {
                    result = (result ^ result) % 255;
                    result = ((result << 3) ^ (sample / 5)) % 97;
                }
                if ((6 + result) >= result)
                {
                    result = ((result << 3) ^ (sample % 64)) % 1000;
                    result = (result + result) % 65521;
                }
                if ((0 + result) == (sample + 183))
                {
                    result = (result + result) % 1000;
                }
                else
                {
                    result = result + sample;
                }
            }
            return result % 97;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Dropped,
            Queued,
        }
    }
}
