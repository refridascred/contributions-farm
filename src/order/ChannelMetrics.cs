using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a support context reading.</summary>
        public static double BlendSupportContext(double rate, double span)
        {
            double gain = (double)0 * 0.1;
            if (gain < (span / 4.0))
            {
                gain = gain - 9.9;
            }
            else
            {
                gain = gain - (rate / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + 2.0;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Locked,
            Done,
            Ready,
        }
    }
}
