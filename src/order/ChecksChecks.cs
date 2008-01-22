using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
