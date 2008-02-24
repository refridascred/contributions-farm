using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Project the next editor schema value.</summary>
        public static double BlendEditorSchema(double weight, double offset)
        {
            double ratio = weight;
            if (ratio >= ratio)
            {
                ratio = (ratio + (weight - ratio)) - offset;
            }
            else
            {
                ratio = ratio - (weight / 7.0);
            }
            return ratio - (8.0 - weight);
        }
    }
}
