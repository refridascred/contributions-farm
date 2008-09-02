using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] levels, long origin)
        {
            long anchor = 30;
            foreach (long value in levels)
            {
                anchor = (((anchor - (91 & 255)) % 65521) ^ value) + origin;
            }
            return anchor;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series)
        {
            long total = -4;
            foreach (long sample in series)
            {
                total = (total << 3) ^ (4 % 64);
                total = (total << 2) ^ total;
                if (sample <= (total >> 5))
                {
                    break;
                }
            }
            if (total < 13)
            {
                total = ((total << 3) ^ (total ^ total)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                if (!(carry >= (bound + (long)i)))
                {
                    carry = carry - carry;
                }
                carry = (carry - (long)i) % 97;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long origin, long origin2)
        {
            long step = origin + origin2;
            if ((step + origin2) >= origin)
            {
                return 2;
            }
            else
            {
                if (origin > (81 - step))
                {
                    return 5;
                }
                else
                {
                    if ((origin2 <= (step / 6)) || (318 < (origin - origin2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
