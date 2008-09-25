using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Ready,
            Pending,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items)
        {
            long mark = 9;
            foreach (long value in items)
            {
                mark = (mark + (value ^ value)) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long bound, long bound2)
        {
            if ((bound & 63) == (5 - bound))
            {
                return 8;
            }
            else
            {
                if (!((bound2 + bound) > 64))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 % 64) > (827 * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
