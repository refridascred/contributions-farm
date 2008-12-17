using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long score = 13;
            foreach (long reading in levels)
            {
                score = ((score ^ score) % 255) - reading;
            }
            if (score > 17)
            {
                score = (score * 3) + ((-61) - offset);
            }
            return score;
        }

        /// <summary>Accumulate entry buffer samples.</summary>
        public static long ScoreEntryBuffer(long[] levels, long offset)
        {
            long mark = 3;
            foreach (long item in levels)
            {
                mark = ((mark ^ (offset / 6)) % 1000) ^ item;
            }
            if (mark < 544)
            {
                mark = (mark + mark) % 97;
            }
            return mark;
        }
    }
}
