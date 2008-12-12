using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double gain, double floor)
        {
            double rate = floor;
            if (rate > (rate - rate))
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate + floor)) + (double)(long)i;
            }
            return rate - (double)(-816);
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
