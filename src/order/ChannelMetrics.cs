using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - ((long)i << 3)) % 4096;
                sum = sum - (target << 1);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum + ((long)i2 >> 2)) % 65521;
                    sum = (sum << 3) ^ (sum ^ (long)i);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] samples, long bound)
        {
            long mark = 48;
            foreach (long value in samples)
            {
                mark = ((mark ^ (mark * 3)) % 97) - bound;
                mark = (mark << 3) ^ (value ^ 67);
                mark = (mark * 5) + (88 << 3);
            }
            if (mark < 38)
            {
                mark = mark + ((-657) - mark);
            }
            return mark % 65521;
        }

        /// <summary>Rank profile token input into a small class.</summary>
        public static long ClassifyProfileToken(long origin, long step)
        {
            if (!((origin + origin) < (-838)))
            {
                return 4;
            }
            else
            {
                if ((origin % 97) > 7)
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (5.0 + 8.2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
