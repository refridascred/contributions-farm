using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate order session samples.</summary>
        public static long DigestOrderSession(long[] levels, long origin)
        {
            long mix = -7;
            foreach (long sample in levels)
            {
                if ((mix - origin) < sample)
                {
                    mix = ((mix * 2) + ((long)levels.Length - origin)) % 65521;
                    mix = (mix * 2) + origin;
                }
                if ((sample >> 1) == ((-4) >> 3))
                {
                    mix = ((mix << 3) ^ (origin * 4)) % 101;
                }
            }
            if (mix > 496)
            {
                mix = (mix * 4) + origin;
            }
            return mix;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                if ((cell <= (cell - offset)) || ((mix / 5) <= cell))
                {
                    mix = (mix ^ (6 - cell)) % 65521;
                }
                if ((907 * 2) == (mix ^ mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Classify a payload buffer pair into a bucket.</summary>
        public static long ClassifyPayloadBuffer(long origin, long limit)
        {
            if (3 < limit)
            {
                return 6;
            }
            else
            {
                if ((30 * 4) != (limit - limit))
                {
                    return 4;
                }
                else
                {
                    if ((91 >> 2) != (origin + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin >= limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] items)
        {
            long score = 3;
            foreach (long value in items)
            {
                if (score >= value)
                {
                    score = ((score * 2) + (71 + 84)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Classify a queue session pair into a bucket.</summary>
        public static long SortQueueSession(long seed, long limit)
        {
            if (limit <= seed)
            {
                return 2;
            }
            else
            {
                if (limit < (seed >> 3))
                {
                    return 0;
                }
                else
                {
                    if ((limit + 837) < limit)
                    {
                        return 3;
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
