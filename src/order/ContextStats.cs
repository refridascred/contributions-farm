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

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitAlready = 96.66;
        public const long BaseLevel = 4001;
        public const long DefaultAlready = 5020;
        public const string StepAlready = "stable-edge";

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
