using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up window session samples.</summary>
        public static long PairWindowSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long offset)
        {
            long lane = target ^ offset;
            if ((lane ^ offset) >= lane)
            {
                return 6;
            }
            else
            {
                if (0.72 >= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (13.0 <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.79 / 6.0) > (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long offset, long origin)
        {
            long edge = offset + origin;
            if ((double)edge > (7.27 / 2.0))
            {
                return 0;
            }
            else
            {
                if (((820 + origin) >= (origin / 4)) && (edge >= (5 - 494)))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin > (3.9 - 0.8))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm metric readings.</summary>
        public static long CombineGithubfarmMetric(long[] values, long seed)
        {
            long mix = 8;
            foreach (long sample in values)
            {
                mix = (mix ^ mix) + seed;
                mix = (mix + (sample / 8)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Draft,
            Stale,
            Ready,
        }
    }
}
