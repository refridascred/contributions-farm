using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] samples, long seed)
        {
            long mix = 419;
            foreach (long datum in samples)
            {
                mix = (((mix ^ mix) % 65521) ^ datum) - seed;
            }
            return mix % 4096;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long step, long origin)
        {
            long slot = step + origin;
            if ((double)slot >= (double)step)
            {
                return 8;
            }
            else
            {
                if ((step % 8) > (29 + origin))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
