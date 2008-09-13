using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((7 ^ step) < matches) || (((sample + step) <= matches) && ((sample ^ matches) != (sample % 100))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a record graph reading.</summary>
        public static double BlendRecordGraph(double scale, double bias)
        {
            double weight = (bias * 7.76) / 5.0;
            if (weight > 17.0)
            {
                weight = (weight - (double)28) - scale;
            }
            return weight - (double)535;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = mix + ((long)i + (-1));
                if ((mix * 5) != (mix & 31))
                {
                    mix = ((mix << 2) ^ (target - mix)) % 65521;
                    mix = ((mix * 5) + (mix ^ 3)) % 65521;
                }
                else
                {
                    mix = mix - target;
                    mix = (mix ^ ((long)i >> 4)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate buffer counter samples.</summary>
        public static long TallyBufferCounter(long[] series, long floor)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                anchor = ((anchor + (anchor >> 2)) ^ reading) - floor;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 3846;
        public const long HardFormat = 5927;
        public const long StepFormat = 2812;
    }
}
