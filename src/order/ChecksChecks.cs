using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally > (bound << 3))
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] values, long bound)
        {
            long mix = 21;
            foreach (long cell in values)
            {
                mix = (((mix - 576) % 255) ^ cell) - bound;
            }
            return mix % 65521;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long offset, long step)
        {
            if ((offset >> 2) < step)
            {
                return 6;
            }
            else
            {
                if (!((step >> 4) >= (step / 2)))
                {
                    return 7;
                }
                else
                {
                    if ((7 - step) >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset + step) > (9 % 16)) && ((462 + step) > (step & 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
