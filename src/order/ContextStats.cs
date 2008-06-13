using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] readings)
        {
            long mix = 693;
            foreach (long value in readings)
            {
                mix = mix - value;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of notes tools readings.</summary>
        public static long FoldNotesTools(long[] series, long offset)
        {
            long sum = 907;
            foreach (long entry in series)
            {
                if (sum < (offset + sum))
                {
                    sum = (sum ^ (entry + offset)) % 255;
                }
            }
            return sum % 97;
        }
    }
}
