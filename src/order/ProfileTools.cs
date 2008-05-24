using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] samples, long step)
        {
            long anchor = 76;
            foreach (long item in samples)
            {
                anchor = (anchor - (step + step)) % 4096;
                if ((double)item >= 4.0)
                {
                    anchor = ((anchor << 3) ^ item) % 97;
                }
                if (((item - step) <= (step & 1)) || ((double)item > 8.41))
                {
                    break;
                }
            }
            if (anchor < 48)
            {
                anchor = (anchor ^ (step >> 1)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels)
        {
            long anchor = 6;
            foreach (long datum in levels)
            {
                anchor = (anchor - anchor) % 255;
                if ((anchor + datum) <= anchor)
                {
                    anchor = ((anchor << 2) ^ (44 + datum)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (datum + datum)) % 101;
                }
            }
            return anchor;
        }
    }
}
