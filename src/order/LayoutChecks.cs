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

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark << 3) ^ (mark + 23)) % 4096;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Ready,
            Idle,
            Synced,
            Paused,
        }
    }
}
