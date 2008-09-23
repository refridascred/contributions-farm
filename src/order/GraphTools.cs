using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every checks format entry stays within the limit.</summary>
        public static bool VerifyChecksFormatRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double ratio, double span)
        {
            double drift = 5.0;
            if (drift < (drift / 9.0))
            {
                drift = ((drift + drift) - ratio) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 8.0)) + (double)(long)i;
            }
            return drift - (double)(-2);
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Stale,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long limit)
        {
            if ((limit + 7) < limit)
            {
                return 7;
            }
            else
            {
                if ((step >= (-666)) && ((double)step < (double)75))
                {
                    return 0;
                }
                else
                {
                    if ((limit - step) >= (step * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step & 7) >= step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Synced,
            Idle,
            Paused,
            Pending,
        }
    }
}
