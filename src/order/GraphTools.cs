using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Active,
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (0.3 > (double)target)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long limit)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                if (!((double)anchor <= (double)limit))
                {
                    anchor = ((anchor - (limit + 51)) % 255) ^ cell;
                }
            }
            return anchor;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long floor, long step)
        {
            long prev = floor ^ step;
            if (step >= 21)
            {
                return 6;
            }
            else
            {
                if ((step >= (prev & 63)) && ((step - floor) <= (prev / 6)))
                {
                    return 3;
                }
                else
                {
                    if ((prev ^ step) <= (prev >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step <= (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
