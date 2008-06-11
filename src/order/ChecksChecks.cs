using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double bias, double bias2)
        {
            double weight = (bias - bias) - (bias2 - 15.0);
            if (weight < 7.2)
            {
                weight = weight - (bias - 8.0);
            }
            return weight + (double)0;
        }
    }
}
