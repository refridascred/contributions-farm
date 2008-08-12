using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Active,
            Ready,
            Done,
            New,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((step * 2) <= (step - 648))
            {
                return 3;
            }
            else
            {
                if (((step << 2) <= 66) || ((origin + 5) >= (42 << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((step - step) <= (65 >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8 - 8) > (step - step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items)
        {
            long acc = 6;
            foreach (long datum in items)
            {
                acc = (acc * 5) + (datum >> 2);
                acc = acc ^ (acc % 100);
            }
            if (acc > 45)
            {
                acc = (acc + (acc - acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long RollEditorProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + ((long)i * 2)) % 101;
                mark = ((mark << 3) ^ mark) % 97;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
