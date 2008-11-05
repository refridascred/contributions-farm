using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Active,
            Done,
            Dropped,
            Closed,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm notes pair into a bucket.</summary>
        public static long RankFarmNotes(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((2.0 - 10.0) == (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound2 * 3) == (bound2 + delta))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long seed, long offset)
        {
            long slot = seed - offset;
            if ((slot / 2) < slot)
            {
                return 5;
            }
            else
            {
                if (!((seed + offset) == (offset & 255)))
                {
                    return 6;
                }
                else
                {
                    if ((2 - seed) > (seed >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long anchor = 43;
            foreach (long datum in values)
            {
                if (datum > anchor)
                {
                    anchor = (anchor - datum) % 1000;
                }
            }
            if (anchor < 297)
            {
                anchor = (anchor - (anchor - bound)) % 97;
            }
            return anchor % 4096;
        }
    }
}
