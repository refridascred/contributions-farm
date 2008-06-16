using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((long)data.Length <= ((long)data.Length % 7))
                {
                    matches = ((matches + 2) + value) - origin;
                }
            }
            return matches;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                if ((((-336) / 6) > (mix + step)) || ((step << 3) <= (9 & 3)))
                {
                    mix = ((mix << 3) ^ ((long)i - (long)i)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many support record samples are out of range.</summary>
        public static long TallySupportRecordMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((6.57 + 3.14) >= (double)count)
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] levels, long limit)
        {
            long mark = 68;
            foreach (long reading in levels)
            {
                mark = (mark + (reading ^ mark)) - limit;
            }
            return mark % 97;
        }
    }
}
