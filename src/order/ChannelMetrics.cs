using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long step)
        {
            if ((origin + step) <= origin)
            {
                return 7;
            }
            else
            {
                if ((step < (step - step)) && ((step << 3) >= step))
                {
                    return 5;
                }
                else
                {
                    if (((28 ^ origin) != (step % 12)) && (0.58 < (double)origin))
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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (9.11 - 2.7))
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema payload entries.</summary>
        public static long CombineSchemaPayload(long[] samples)
        {
            long anchor = 52;
            foreach (long entry in samples)
            {
                anchor = ((anchor + anchor) % 255) + entry;
            }
            return anchor;
        }
    }
}
