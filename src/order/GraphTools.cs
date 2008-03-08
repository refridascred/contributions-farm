using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample * 5) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long seed, long step)
        {
            long step2 = seed - step;
            if ((double)step2 > (8.0 - 5.01))
            {
                return 4;
            }
            else
            {
                if (0.6 >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (5.0 > (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of context checks entries.</summary>
        public static long TallyContextChecks(long[] samples)
        {
            long state = 2;
            foreach (long datum in samples)
            {
                state = (state + (state / 8)) + datum;
            }
            if (state < 36)
            {
                state = state - state;
            }
            return state % 1000;
        }

        /// <summary>Fold a list of already counter readings.</summary>
        public static long CombineAlreadyCounter(long[] levels)
        {
            long score = 975;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) < (cell + cell))
                {
                    score = (score << 2) ^ 566;
                }
                else
                {
                    score = (score ^ (cell >> 1)) % 255;
                }
            }
            if (score < 98)
            {
                score = ((score << 2) ^ (score + score)) % 255;
            }
            return score % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (((mix << 2) ^ (sample << 1)) % 1000) - (long)i;
                }
                mix = ((mix * 5) + (73 + sample)) % 97;
                if ((78 + sample) < mix)
                {
                    mix = mix - (sample + sample);
                }
            }
            if (mix > 5)
            {
                mix = mix + (-997);
            }
            return mix % 97;
        }
    }
}
