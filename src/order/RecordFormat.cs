using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank metrics entry input into a small class.</summary>
        public static long SortMetricsEntry(long offset, long step)
        {
            if (!((offset - step) != (716 * 2)))
            {
                return 2;
            }
            else
            {
                if (step > (4 / 2))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double gain, double span)
        {
            double weight = span;
            if (weight <= 0.7)
            {
                weight = (weight - (0.4 / 6.0)) - gain;
            }
            return weight - 1.1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Closed,
            Stale,
            Dropped,
        }
    }
}
