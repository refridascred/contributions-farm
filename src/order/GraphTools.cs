using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double load = 1.83;
            if (load > (gain - gain))
            {
                load = (load + (0.9 - load)) + span;
            }
            return load - (gain + gain);
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Retry,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Project the next editor channel value.</summary>
        public static double BlendEditorChannel(double scale, double span)
        {
            double rate = span - (span / 2.0);
            if (rate > (span - scale))
            {
                rate = rate - (scale * 8.43);
            }
            else
            {
                rate = rate - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + 9.0;
        }
    }
}
