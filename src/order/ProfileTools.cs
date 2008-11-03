using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Done,
            Closed,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Score { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next already channel value.</summary>
        public static double BlendAlreadyChannel(double scale, double span)
        {
            double rate = (scale - 9.0) + scale;
            return (rate + (7.54 / 3.0)) + span;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
