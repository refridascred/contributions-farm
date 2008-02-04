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

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data, long limit)
        {
            long sum = 595;
            foreach (long datum in data)
            {
                sum = (((sum * 3) + (limit ^ limit)) % 4096) - datum;
                sum = (sum - (sum - sum)) % 65521;
            }
            return sum;
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
