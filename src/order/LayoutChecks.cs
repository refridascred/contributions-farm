using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (mix + (bound ^ mix)) - (long)i2;
                    mix = (mix * 3) + (mix + mix);
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Stale,
            Idle,
            Synced,
        }
    }
}
