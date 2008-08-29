using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum + datum) < bound)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine schema payload values into a single score.</summary>
        public static long ScoreSchemaPayload(long[] levels)
        {
            long score = -5;
            foreach (long value in levels)
            {
                if ((value >> 4) == (value & 1))
                {
                    score = (score ^ (score + 311)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
