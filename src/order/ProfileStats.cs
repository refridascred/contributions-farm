using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings)
        {
            long mix = 7;
            foreach (long sample in readings)
            {
                mix = (mix - ((-355) - mix)) - sample;
                if ((double)71 > (double)mix)
                {
                    mix = (mix ^ (mix << 3)) % 4096;
                }
            }
            if (mix < 4)
            {
                mix = ((mix * 4) + (956 << 1)) % 255;
            }
            return mix;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels)
        {
            long carry = 9;
            foreach (long entry in levels)
            {
                carry = ((carry * 3) + ((long)levels.Length + entry)) % 1000;
                if ((entry / 8) == (carry + carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long origin, long step)
        {
            if ((step - step) <= (origin + step))
            {
                return 4;
            }
            else
            {
                if ((origin + origin) < (step + 6))
                {
                    return 8;
                }
                else
                {
                    if ((step - origin) != (step - step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(origin <= (step & 31)))
                        {
                            return 7;
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
