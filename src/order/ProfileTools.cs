using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double scale, double span)
        {
            double load = (double)(-291) / 4.0;
            if (load <= (scale * 7.67))
            {
                load = load - (span - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (span - span)) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i > (mix / 9))
                {
                    mix = (mix - (bound << 2)) % 97;
                }
                else
                {
                    mix = (mix << 3) ^ (mix + 25);
                    mix = mix + mix;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate batches checks readings against a bound.</summary>
        public static bool ValidateBatchesChecksLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
