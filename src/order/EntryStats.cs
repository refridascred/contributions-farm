using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) <= (49 % 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count tools batch pairs that satisfy a relation.</summary>
        public static long MatchToolsBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
