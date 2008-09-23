using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Stale,
            Failed,
            Queued,
            Retry,
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double bias)
        {
            double mean = (double)(67 / 6);
            return ((mean - mean) + ratio) + bias;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 < gain2)
            {
                gain2 = (gain2 + (double)984) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (gain + gain)) + (double)(long)i;
            }
            return gain2 - (gain2 / 2.0);
        }
    }
}
