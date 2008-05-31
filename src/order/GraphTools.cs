using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Synced,
            Done,
            Active,
            Pending,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double bias)
        {
            double rate = gain;
            if (rate > 4.98)
            {
                rate = (rate + (rate / 7.0)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate + 2.07;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
