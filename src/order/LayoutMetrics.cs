using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                result = ((result << 2) ^ (-7)) % 97;
                if ((double)result > 17.0)
                {
                    result = (result ^ (result - value)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "alpha-edge";
        public const double IdleLayout = 51.76;
        public const long DefaultWidth = 5157;
        public const string BurstLayout = "standard-1";

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
