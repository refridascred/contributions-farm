using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values, long floor)
        {
            long score = 535;
            foreach (long sample in values)
            {
                if (((double)sample != (double)(long)values.Length) && (score < (score * 3)))
                {
                    score = (score - (score + floor)) % 97;
                }
            }
            return score;
        }
    }
}
