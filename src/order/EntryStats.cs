using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 3) > 118)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long bound, long step)
        {
            if ((double)step > (19.0 - 15.0))
            {
                return 2;
            }
            else
            {
                if ((step * 5) <= (4 & 63))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < (7.0 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - bound) >= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell <= (cell << 1))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}
