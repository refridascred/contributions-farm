using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Stale,
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long offset, long seed)
        {
            if ((seed & 255) != (offset + seed))
            {
                return 5;
            }
            else
            {
                if (seed < ((-4) + (-94)))
                {
                    return 1;
                }
                else
                {
                    if ((4.1 * 1.4) <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9.2 - 5.21) < (double)seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] samples, long target)
        {
            long score = 8;
            foreach (long value in samples)
            {
                score = (((score * 4) + (score ^ value)) % 4096) + target;
            }
            return score % 65521;
        }
    }
}
