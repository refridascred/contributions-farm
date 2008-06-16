using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6577;
        public const long SoftInterval = 4456;
        public const long MaxLevel = 7190;
        public const long StepBatch = 5671;

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
