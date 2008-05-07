using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] data)
        {
            long state = 6;
            foreach (long reading in data)
            {
                if (state <= (reading + state))
                {
                    state = ((state << 3) ^ ((long)data.Length >> 5)) % 4096;
                }
                if (((double)(long)data.Length > (0.2 / 9.0)) || ((844 * 4) >= reading))
                {
                    state = (state + reading) % 97;
                }
                state = state + (reading + state);
            }
            if (state > 9)
            {
                state = ((state << 2) ^ (-214)) % 97;
            }
            return state;
        }
    }
}
