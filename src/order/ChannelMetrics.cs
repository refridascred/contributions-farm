using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a token notes pair into a bucket.</summary>
        public static long BucketTokenNotes(long origin, long step)
        {
            if (((3.0 / 2.0) > (double)step) || (step >= origin))
            {
                return 8;
            }
            else
            {
                if (step <= (origin / 9))
                {
                    return 3;
                }
                else
                {
                    if ((3.6 + 6.41) >= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step - step) < origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Ready,
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor << 2) ^ seed;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
