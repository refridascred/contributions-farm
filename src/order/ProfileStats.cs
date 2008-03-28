using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long offset)
        {
            long offset2 = origin - offset;
            if (origin >= offset2)
            {
                return 6;
            }
            else
            {
                if (!((origin / 3) != (offset2 << 2)))
                {
                    return 5;
                }
                else
                {
                    if (offset2 > origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 2493;
        public const long SoftFactor = 7782;
        public const long StepSpan = 4668;

        /// <summary>Fold a list of buffer stats readings.</summary>
        public static long TallyBufferStats(long[] series)
        {
            long anchor = 90;
            foreach (long datum in series)
            {
                if (88 >= (anchor - datum))
                {
                    anchor = (anchor ^ datum) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Classify a context stats pair into a bucket.</summary>
        public static long ClassifyContextStats(long seed, long step)
        {
            long offset = seed + step;
            if ((890 * 3) < (step % 10))
            {
                return 0;
            }
            else
            {
                if ((seed / 3) < (seed ^ offset))
                {
                    return 5;
                }
                else
                {
                    if ((seed % 3) > seed)
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
