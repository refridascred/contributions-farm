using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first batches context entry that matches the target.</summary>
        public static long SeekBatchesContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Paused,
            Active,
            Failed,
            Done,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings)
        {
            long anchor = 0;
            foreach (long cell in readings)
            {
                anchor = (anchor * 2) + (525 + cell);
            }
            if (anchor < (-76))
            {
                anchor = (anchor - (anchor >> 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit stream layout readings against a rule.</summary>
        public static long TallyStreamLayoutMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (4.74 <= (double)origin)
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long seed)
        {
            long bound = origin - seed;
            if ((20.0 / 5.0) == (double)bound)
            {
                return 7;
            }
            else
            {
                if (!((bound + 692) > (origin ^ 611)))
                {
                    return 6;
                }
                else
                {
                    if ((60 + seed) <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + 8) <= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
