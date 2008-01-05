using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((5.9 - 9.69) < (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long seed, long step)
        {
            if (step >= (step & 63))
            {
                return 6;
            }
            else
            {
                if ((19.0 - 8.0) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (seed <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            Queued,
            Stale,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long seed)
        {
            long anchor = 1;
            foreach (long sample in values)
            {
                if (!(((double)seed >= (4.7 / 3.0)) || (5 <= seed)))
                {
                    anchor = (anchor + (seed - seed)) % 65521;
                }
                anchor = (anchor << 2) ^ (seed + seed);
                if ((sample - sample) != (sample & 127))
                {
                    break;
                }
            }
            if (anchor < 95)
            {
                anchor = ((anchor << 2) ^ seed) % 255;
            }
            return anchor;
        }
    }
}
