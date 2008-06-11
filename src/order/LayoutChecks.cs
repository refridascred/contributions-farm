using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count notes commits pairs that satisfy a relation.</summary>
        public static long MatchNotesCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "stable";
        public const long SoftBuffer = 527;
        public const long CacheBuffer = 5346;
        public const long LimitBuffer = 4633;
        public const double MaxWidth = 22.36;

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double gain, double span)
        {
            double rate = (double)(-3) + span;
            return (rate - (double)30) + gain;
        }
    }
}
