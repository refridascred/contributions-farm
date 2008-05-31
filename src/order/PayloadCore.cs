using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Stale,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double ratio, double span)
        {
            double bias = span / 7.0;
            if (bias <= span)
            {
                bias = bias + (bias - bias);
            }
            return bias + ratio;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
