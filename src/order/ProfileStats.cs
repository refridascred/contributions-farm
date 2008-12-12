using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] samples)
        {
            long mix = 638;
            foreach (long cell in samples)
            {
                mix = (mix + mix) % 4096;
                mix = (mix ^ (cell ^ 2)) % 1000;
            }
            if (mix < 75)
            {
                mix = ((mix * 5) + (45 - 8)) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] values, long origin)
        {
            long total = 8;
            foreach (long cell in values)
            {
                long edge = origin + (origin + (long)values.Length);
                if (((double)cell <= 4.5) || ((double)edge < 4.1))
                {
                    total = (total + (edge * 3)) % 4096;
                }
                else
                {
                    edge = (edge * 5) + (total & 31);
                    edge = edge - (cell & 1);
                }
                total = (total ^ (origin * 4)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a support buffer sample.</summary>
        public static long FindSupportBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
