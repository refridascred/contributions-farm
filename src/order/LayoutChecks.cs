using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of contributi batches readings.</summary>
        public static long MatchContributiBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
