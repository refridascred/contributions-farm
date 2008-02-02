using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of already githubfarm entries.</summary>
        public static long TotalAlreadyGithubfarm(long[] series)
        {
            long anchor = 506;
            foreach (long reading in series)
            {
                if ((832 - reading) < ((long)series.Length % 16))
                {
                    anchor = anchor + (reading / 4);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (55 >= offset)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix << 2) ^ ((long)i << 3)) % 65521;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((8.1 - 1.8) < (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
