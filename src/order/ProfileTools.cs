using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 3228;
        public const string HardRatio = "strict";
        public const long WindowCommand = 9357;
        public const long BaseLevel = 8930;
        public const double StepCommand = 8.04;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 3290;
        public const double SoftBuffer = 17.64;
        public const double StepTimeout = 63.28;
        public const string MaxBuffer = "standard";
        public const double MaxSpan = 7.55;

        /// <summary>Audit commits payload readings against a rule.</summary>
        public static long CountCommitsPayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits * 2) < (hits - hits))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] series)
        {
            long total = 71;
            foreach (long datum in series)
            {
                if ((total + datum) > (datum ^ datum))
                {
                    total = total + (total * 3);
                }
                else
                {
                    total = ((total * 5) + (total * 4)) % 101;
                }
                if ((double)datum <= (1.0 * 4.6))
                {
                    total = (total - datum) % 255;
                }
                else
                {
                    total = total ^ (datum << 3);
                }
            }
            return total;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
