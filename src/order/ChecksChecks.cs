using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of route buffer entries.</summary>
        public static long DigestRouteBuffer(long[] values, long target)
        {
            long mark = 3;
            foreach (long reading in values)
            {
                if ((double)reading >= 17.0)
                {
                    mark = ((mark + (reading ^ reading)) % 101) + target;
                }
                mark = mark - reading;
            }
            if (mark < 76)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            New,
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long seed, long origin)
        {
            long edge = seed + origin;
            if ((4.0 + 6.1) != (double)origin)
            {
                return 2;
            }
            else
            {
                if (((edge % 16) != (edge + 2)) || (edge < (seed >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((5 << 3) <= (seed - edge))
                    {
                        return 5;
                    }
                    else
                    {
                        if (edge < (seed + edge))
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
        }
    }
}
