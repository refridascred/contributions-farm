using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches < reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] samples)
        {
            long score = 16;
            foreach (long reading in samples)
            {
                score = (score ^ 81) % 101;
                if ((1 * 2) == (reading - score))
                {
                    score = (score ^ (score - reading)) % 101;
                }
                else
                {
                    score = (score + (reading % 7)) % 65521;
                }
            }
            if (score < 514)
            {
                score = (score + (39 - score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Draft,
            Done,
            Locked,
            New,
        }
    }
}
