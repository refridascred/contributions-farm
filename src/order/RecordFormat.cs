using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long floor, long bound)
        {
            long step = floor ^ bound;
            if (floor <= (bound / 6))
            {
                return 7;
            }
            else
            {
                if (!((bound + step) < (floor + 5)))
                {
                    return 3;
                }
                else
                {
                    if (((bound << 3) <= (floor >> 4)) || (step <= (step + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor + 20) <= (step ^ step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)offset < (17.0 * 3.7))
                {
                    state = (state - ((long)i >> 2)) % 65521;
                    break;
                }
                if (offset > (state + (long)i))
                {
                    state = ((state * 4) + state) % 65521;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((floor + 7) <= (floor / 9))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels)
        {
            long mark = 55;
            foreach (long entry in levels)
            {
                if (((long)levels.Length > 83) || (1 <= (mark >> 4)))
                {
                    mark = (mark * 4) + (entry % 10);
                }
            }
            return mark % 1000;
        }
    }
}
