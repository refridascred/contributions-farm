using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit metric graph readings against a rule.</summary>
        public static long CountMetricGraphMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((((hits + cell) == (hits ^ cell)) && ((cell + 2) > (hits * 5))) || ((cell > (389 / 9)) && ((cell - cell) == ((-63) << 3))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 9;
        public const long CacheSpan = 6218;
        public const double SoftLevel = 82.72;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
            public double Weight { get; set; }
            public bool Mode { get; set; }
        }
    }
}
