using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values)
        {
            long anchor = 9;
            foreach (long sample in values)
            {
                if ((anchor << 3) > sample)
                {
                    anchor = (anchor + (anchor - (long)values.Length)) % 4096;
                    continue;
                }
                else
                {
                    anchor = anchor - sample;
                }
                anchor = anchor ^ (sample + anchor);
                if (!((double)anchor != (double)sample))
                {
                    break;
                }
            }
            if (anchor < 70)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a buffer tools counter forward.</summary>
        public static long SeriesBufferTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
