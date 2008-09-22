using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((origin - cell) <= 2) || ((2 - origin) < origin))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Accumulate graph already samples.</summary>
        public static long DigestGraphAlready(long[] series)
        {
            long mark = 5;
            foreach (long reading in series)
            {
                if (reading > (reading - mark))
                {
                    mark = ((mark << 3) ^ (mark % 16)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
