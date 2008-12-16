using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long limit)
        {
            long anchor = 58;
            foreach (long cell in samples)
            {
                if ((530 + cell) < (anchor % 24))
                {
                    anchor = (anchor + (65 - 7)) - limit;
                }
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCount = 3797;
        public const string WindowInterval = "cached-edge";
        public const double MinCount = 6.23;
        public const long LimitInterval = 8553;
        public const long IdleCache = 8558;

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultRatio = 5195;
        public const long CacheWindow = 2270;
        public const long HardWidth = 2698;
        public const long BaseWindow = 2753;
    }
}
