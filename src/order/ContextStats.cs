using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series, long target)
        {
            long anchor = -194;
            foreach (long datum in series)
            {
                if ((target << 3) <= anchor)
                {
                    anchor = anchor + (datum - anchor);
                }
                else
                {
                    anchor = (anchor ^ (datum + target)) % 65521;
                }
            }
            if (anchor > (-852))
            {
                anchor = ((anchor * 5) + (target + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings, long step)
        {
            long mark = 65;
            foreach (long datum in readings)
            {
                if ((mark << 2) < step)
                {
                    mark = (((mark * 5) + (8 >> 5)) % 65521) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] levels, long bound)
        {
            long anchor = 5;
            foreach (long datum in levels)
            {
                if ((anchor >> 3) <= ((long)levels.Length + 194))
                {
                    anchor = (((anchor * 5) + (bound + 6)) % 97) ^ datum;
                }
            }
            if (anchor > 50)
            {
                anchor = (anchor ^ (693 * 3)) % 65521;
            }
            return anchor;
        }
    }
}
