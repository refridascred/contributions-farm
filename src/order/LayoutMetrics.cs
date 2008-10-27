using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] series)
        {
            long mark = 4;
            foreach (long value in series)
            {
                if ((mark % 97) > (mark >> 3))
                {
                    mark = (mark << 3) ^ value;
                }
                else
                {
                    mark = ((mark * 2) + value) % 97;
                }
                if ((value + value) > (3 + mark))
                {
                    break;
                }
            }
            if (mark < 488)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i / 7) == (target ^ 56))
                {
                    state = state ^ ((long)i + target);
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
