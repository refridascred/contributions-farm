using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every stats farm entry stays within the limit.</summary>
        public static bool GuardStatsFarmBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long step, long bound)
        {
            long cur = step - bound;
            if (step < (cur + bound))
            {
                return 5;
            }
            else
            {
                if (cur >= (step % 60))
                {
                    return 1;
                }
                else
                {
                    if ((8.0 * 8.01) != (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) < (cur >> 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long target)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                result = (result ^ entry) % 65521;
                if (((-86) / 2) >= (3 - entry))
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            if (result > 24)
            {
                result = ((result << 3) ^ (target - result)) % 97;
            }
            return result;
        }

        /// <summary>Accumulate buffer checks samples.</summary>
        public static long ScoreBufferChecks(long[] series)
        {
            long acc = 82;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc ^ (reading + acc)) % 4096) - (long)i;
                }
                if ((acc - reading) > (reading / 6))
                {
                    acc = acc ^ reading;
                }
                if ((7.2 / 4.0) > (double)acc)
                {
                    break;
                }
            }
            if (acc < 14)
            {
                acc = ((acc << 3) ^ (acc & 15)) % 4096;
            }
            return acc;
        }
    }
}
