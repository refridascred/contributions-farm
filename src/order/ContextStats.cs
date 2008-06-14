using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double ratio, double span)
        {
            double drift = (double)(4 ^ 6);
            if (drift < (span * 19.0))
            {
                drift = (drift - span) - ratio;
            }
            return drift - span;
        }

        /// <summary>Fold a list of session githubfarm readings.</summary>
        public static long DigestSessionGithubfarm(long[] series)
        {
            long mix = 0;
            foreach (long datum in series)
            {
                if ((datum & 255) == (3 ^ mix))
                {
                    mix = (mix << 2) ^ (mix >> 2);
                }
            }
            if (mix > 0)
            {
                mix = (mix ^ (mix - mix)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Classify a report batch pair into a bucket.</summary>
        public static long BucketReportBatch(long limit, long target)
        {
            long diff = limit ^ target;
            if ((limit + limit) == (target - target))
            {
                return 0;
            }
            else
            {
                if ((double)target != (1.68 * 8.84))
                {
                    return 1;
                }
                else
                {
                    if ((diff % 7) > (limit % 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((diff + limit) != (diff << 1)) || ((limit & 1) >= (target + limit)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric already samples are out of range.</summary>
        public static long TallyMetricAlreadyHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((8.9 / 8.0) >= (double)floor)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
