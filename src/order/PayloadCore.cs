using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Stale,
            Done,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample + tally) >= (sample << 1))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Classify a farm filter pair into a bucket.</summary>
        public static long BucketFarmFilter(long step, long limit)
        {
            if ((4.24 + 3.2) != (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit & 15) != (step ^ 762))
                {
                    return 8;
                }
                else
                {
                    if (((limit + step) <= (step + limit)) || ((3.58 / 8.0) >= (double)limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a notes editor reading by value.</summary>
        public static long LocateNotesEditorIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
