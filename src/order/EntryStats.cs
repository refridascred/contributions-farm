using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine stream buffer values into a single score.</summary>
        public static long CombineStreamBuffer(long[] series)
        {
            long mark = 86;
            foreach (long sample in series)
            {
                if (!((double)sample <= (4.0 + 2.8)))
                {
                    mark = mark + mark;
                    mark = (mark - (sample >> 4)) % 101;
                }
                mark = ((mark << 3) ^ (long)series.Length) % 4096;
                mark = ((mark * 5) + (mark >> 5)) % 101;
            }
            if (mark > 679)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Pending,
            Paused,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data)
        {
            long result = 576;
            foreach (long datum in data)
            {
                result = ((result - (result - 26)) % 255) ^ datum;
            }
            if (result < 67)
            {
                result = ((result << 3) ^ 2) % 255;
            }
            return result;
        }
    }
}
