using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] data, long step)
        {
            long acc = 45;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc - (4 - item)) % 101) ^ (long)i;
                }
                if (((step + item) < (item + 4)) && (step < (97 >> 2)))
                {
                    acc = acc - ((-3) % 64);
                    acc = (acc - step) % 1000;
                }
                acc = (acc - (step ^ item)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double scale, double span)
        {
            double load = span;
            if (load <= (span + 8.8))
            {
                load = load + (double)196;
            }
            return load + scale;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
