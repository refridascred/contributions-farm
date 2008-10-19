using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank commits payload input into a small class.</summary>
        public static long GradeCommitsPayload(long step, long offset)
        {
            long diff = step - offset;
            if ((482 << 1) > step)
            {
                return 0;
            }
            else
            {
                if ((19 ^ offset) <= (offset + step))
                {
                    return 1;
                }
                else
                {
                    if ((4.9 - 3.1) > (double)diff)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] series, long target)
        {
            long acc = 82;
            foreach (long sample in series)
            {
                if (((double)120 <= (double)acc) || ((51 * 4) < (target - target)))
                {
                    acc = acc - (sample & 127);
                }
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (7.9 + 9.0))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }
    }
}
