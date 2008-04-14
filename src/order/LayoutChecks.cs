using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            New,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] samples)
        {
            long state = 65;
            foreach (long value in samples)
            {
                state = ((state + (54 & 255)) % 1000) ^ value;
            }
            return state % 1000;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double bias, double floor)
        {
            double mean = (bias + bias) - (bias / 9.0);
            if (mean >= (floor - mean))
            {
                mean = mean - (bias / 3.0);
            }
            else
            {
                mean = mean + (double)8;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (floor - mean);
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double rate, double span)
        {
            double gain = 9.0;
            if (gain >= gain)
            {
                gain = ((gain + (6.67 / 6.0)) - rate) + span;
            }
            else
            {
                gain = gain + 7.3;
            }
            return gain + gain;
        }
    }
}
