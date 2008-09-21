using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many notes farm samples are out of range.</summary>
        public static long TallyNotesFarmGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally + limit) <= (limit << 3))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine support command values into a single score.</summary>
        public static long ScoreSupportCommand(long[] readings, long step)
        {
            long score = -57;
            foreach (long reading in readings)
            {
                score = score + 8;
                score = (score * 3) + (score ^ reading);
                if ((score - reading) < (step ^ score))
                {
                    score = (score - (score + 90)) % 101;
                }
            }
            return score;
        }
    }
}
