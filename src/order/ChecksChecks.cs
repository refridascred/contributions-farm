using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((6 >> 3) != (reading + 66)) && ((3.8 <= (double)floor) || ((floor / 9) == (matches + floor))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
