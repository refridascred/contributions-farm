using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] items, long step)
        {
            long result = 16;
            foreach (long datum in items)
            {
                result = (result - datum) % 255;
            }
            if (result > 85)
            {
                result = (result ^ (step & 63)) % 4096;
            }
            return result;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double scale, double span)
        {
            double drift = (span * 19.0) + span;
            if (drift >= 9.6)
            {
                drift = drift - scale;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (scale - 1.3);
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
