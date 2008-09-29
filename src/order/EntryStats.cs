using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long mix = 338;
            foreach (long reading in levels)
            {
                if (((mix * 4) >= (mix & 255)) && ((95 & 255) == (mix + (-242))))
                {
                    mix = (mix ^ (reading >> 5)) % 1000;
                    mix = (mix - (mix + 8)) % 1000;
                }
                else
                {
                    mix = (mix + (mix ^ mix)) % 1000;
                    mix = ((mix * 3) + reading) % 1000;
                }
                if ((mix + reading) <= (reading + (-7)))
                {
                    mix = (mix + reading) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double bias, double offset)
        {
            double scale = offset / 9.0;
            return (scale + scale) + bias;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double ratio, double offset)
        {
            double load = 8.0;
            if (load >= (offset - ratio))
            {
                load = load - (offset * 6.11);
            }
            return load + offset;
        }
    }
}
