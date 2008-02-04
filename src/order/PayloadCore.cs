using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((anchor << 1) < 322) || ((anchor + limit) > (3 + anchor)))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long target, long offset)
        {
            long slot = target ^ offset;
            if ((offset % 24) >= (target >> 5))
            {
                return 5;
            }
            else
            {
                if ((slot & 63) > target)
                {
                    return 2;
                }
                else
                {
                    if ((offset & 7) != (target - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample < 6.41)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
