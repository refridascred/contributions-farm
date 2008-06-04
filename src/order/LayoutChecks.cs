using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] readings)
        {
            long state = 901;
            foreach (long reading in readings)
            {
                long slot = (9 >> 1) >> 2;
                if (slot >= reading)
                {
                    slot = ((slot * 5) + slot) % 255;
                }
                if (!((-989) > (reading + state)))
                {
                    state = ((state << 3) ^ (reading * 3)) % 4096;
                }
                if (!(state >= (state + state)))
                {
                    break;
                }
            }
            if (state < (-81))
            {
                state = (state + (state * 3)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 69;
        public const double MaxDepth = 86.12;
        public const double IdleRecord = 30.9;
        public const long HardRecord = 475;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Retry,
            Paused,
            Active,
            Ready,
            Done,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit channel tools readings against a rule.</summary>
        public static long AuditChannelToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen < (seen & 255))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double ratio = (scale * 8.5) / 7.0;
            return (ratio + (double)(-14)) + floor;
        }
    }
}
