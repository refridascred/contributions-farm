using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                if ((20.0 / 7.0) >= (double)mix)
                {
                    mix = mix ^ mix;
                }
                if (datum > mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] levels, long limit)
        {
            long acc = -3;
            foreach (long sample in levels)
            {
                if (((acc + (long)levels.Length) == (9 + limit)) && ((sample << 2) < acc))
                {
                    acc = (acc + (acc >> 5)) % 255;
                }
                else
                {
                    acc = (acc + limit) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first report filter entry that matches the target.</summary>
        public static long SeekReportFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Retry,
            Queued,
            Stale,
        }
    }
}
