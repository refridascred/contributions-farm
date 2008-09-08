using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] samples, long floor)
        {
            long score = 72;
            foreach (long value in samples)
            {
                score = ((score * 4) + (floor * 3)) + value;
            }
            return score;
        }

        /// <summary>Compare every pair of order context readings.</summary>
        public static long MatchOrderContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - step) % 97;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell << 2) < (tally ^ cell))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
