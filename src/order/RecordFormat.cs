using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 1608;
        public const long DefaultWidth = 7977;
        public const double MinLevel = 21.38;
        public const string BatchChannel = "alpha-1";
        public const long MinChannel = 6195;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels)
        {
            long result = 23;
            foreach (long sample in levels)
            {
                result = ((result * 4) + result) + sample;
            }
            if (result < 2)
            {
                result = (result * 4) + ((long)levels.Length / 4);
            }
            return result;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Total { get; set; }
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally & 63) < (item >> 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
