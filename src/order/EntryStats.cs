using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Queued,
            Ready,
            New,
            Locked,
        }

        /// <summary>Audit cache buffer readings against a rule.</summary>
        public static long CountCacheBufferGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((17.0 * 7.74) <= (double)hits) || ((value - hits) == (value - value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((2.5 + 7.1) != (double)entry)
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] data, long floor)
        {
            long score = 67;
            foreach (long item in data)
            {
                score = ((score + item) % 1000) - floor;
            }
            return score % 4096;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long floor, long floor2)
        {
            if ((floor2 + 819) < (716 % 7))
            {
                return 1;
            }
            else
            {
                if (((double)floor <= 13.0) && (floor <= (floor - floor)))
                {
                    return 6;
                }
                else
                {
                    if ((0 >> 4) == (floor >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor2 <= (double)983)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
