using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                if ((acc - (long)i) <= (step % 64))
                {
                    acc = acc - 46;
                    break;
                }
                else
                {
                    acc = ((acc * 3) + (step - step)) % 101;
                    acc = (acc - (step / 4)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] data)
        {
            long anchor = 158;
            foreach (long value in data)
            {
                anchor = ((anchor << 3) ^ (value - value)) % 97;
            }
            if (anchor > 7)
            {
                anchor = anchor - (189 ^ 19);
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many session payload samples are out of range.</summary>
        public static long TallySessionPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value - count) > (37 * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
