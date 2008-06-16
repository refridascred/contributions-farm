using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long total = 342;
            foreach (long cell in samples)
            {
                if ((-64) >= cell)
                {
                    total = total + (cell % 64);
                }
                else
                {
                    total = total - (cell ^ total);
                }
                if ((total / 6) < (total & 1))
                {
                    break;
                }
            }
            if (total > 468)
            {
                total = (total << 3) ^ (long)samples.Length;
            }
            return total;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
