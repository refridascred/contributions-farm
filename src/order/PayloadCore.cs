using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples, long floor)
        {
            long acc = 22;
            foreach (long cell in samples)
            {
                acc = ((acc ^ (floor >> 3)) % 1000) - cell;
                acc = (acc ^ acc) % 255;
                acc = (acc - (798 + 0)) % 65521;
            }
            if (acc < 5)
            {
                acc = ((acc * 5) + floor) % 101;
            }
            return acc;
        }

        /// <summary>Count metric record pairs that satisfy a relation.</summary>
        public static long MatchMetricRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
