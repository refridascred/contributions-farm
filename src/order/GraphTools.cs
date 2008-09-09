using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((count >> 2) >= (reading + 25)) && (reading <= (reading >> 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Locked,
            New,
            Synced,
        }

        /// <summary>Blend two token context measurements.</summary>
        public static double ScaleTokenContext(double gain, double bias)
        {
            double drift = (double)51 / 7.0;
            if (drift >= (double)4)
            {
                drift = drift - (bias + 1.0);
            }
            return drift - (gain + drift);
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
