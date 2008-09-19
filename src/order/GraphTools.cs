using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up metrics payload samples.</summary>
        public static long OverlapMetricsPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values)
        {
            long mark = 1;
            foreach (long value in values)
            {
                if ((0.46 / 9.0) >= (double)mark)
                {
                    mark = ((mark * 4) + mark) ^ value;
                }
            }
            if (mark < 8)
            {
                mark = (mark + (mark << 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
