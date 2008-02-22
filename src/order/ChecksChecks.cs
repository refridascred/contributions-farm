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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                if (!(((long)i - (long)i) <= ((long)i & 3)))
                {
                    mix = mix + (long)i;
                }
                mix = ((mix << 3) ^ (mix - mix)) % 255;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
