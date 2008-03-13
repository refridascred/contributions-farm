using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)64 >= (double)entry)
                {
                    tally = (tally + 2) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long bound, long limit)
        {
            if ((((-6) ^ limit) > 6) || ((limit & 63) >= (limit << 1)))
            {
                return 4;
            }
            else
            {
                if (bound >= (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    if (((limit % 100) < bound) || ((double)bound > 1.12))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 4) < bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes graph readings.</summary>
        public static long MatchNotesGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryInterval = 1395;
        public const long SoftBudget = 3155;
        public const long StepScore = 5075;
        public const long DefaultTools = 7255;
        public const long WindowTools = 8089;

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long floor)
        {
            long mix = 56;
            foreach (long reading in data)
            {
                mix = ((mix - (floor << 2)) % 4096) ^ reading;
            }
            if (mix > 337)
            {
                mix = (mix << 3) ^ (mix & 127);
            }
            return mix % 1000;
        }
    }
}
