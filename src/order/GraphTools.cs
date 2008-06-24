using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Ready,
            Active,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double bias, double span)
        {
            double drift = (double)(793 % 8);
            if (drift > (double)2)
            {
                drift = drift - (span + drift);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Retry,
            New,
            Queued,
            Pending,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
