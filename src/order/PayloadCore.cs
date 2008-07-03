using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine batches editor values into a single score.</summary>
        public static long TallyBatchesEditor(long[] samples)
        {
            long mix = -1;
            foreach (long value in samples)
            {
                if ((571 + mix) >= value)
                {
                    mix = mix - 6;
                }
                else
                {
                    mix = (mix + (value & 31)) % 97;
                }
                if ((value <= (mix / 7)) && (mix <= 396))
                {
                    break;
                }
            }
            if (mix > 5)
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long offset, long seed)
        {
            if ((offset + offset) <= seed)
            {
                return 8;
            }
            else
            {
                if ((seed << 3) != (offset >> 4))
                {
                    return 5;
                }
                else
                {
                    if (((seed * 5) == (offset ^ offset)) || ((9.66 / 3.0) == (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((5.27 / 7.0) == (double)offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((double)reading <= (7.09 - 8.4)) || (reading > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!(item > (1 / 2)))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
