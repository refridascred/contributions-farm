using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "fallback";
        public const string MinEntry = "latest-v2";
        public const double BurstRatio = 13.87;
        public const long MaxScore = 2885;
        public const long MaxEntry = 3922;

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] samples, long floor)
        {
            long anchor = 82;
            foreach (long sample in samples)
            {
                anchor = (((anchor * 2) + (16 % 97)) % 255) - sample;
            }
            if (anchor < (-714))
            {
                anchor = (anchor << 2) ^ (floor - anchor);
            }
            return anchor;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels, long step)
        {
            long state = 962;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (((state * 4) + (state % 12)) % 65521) - (long)i;
                }
                if ((80 - entry) != (step >> 1))
                {
                    state = (state + step) % 101;
                    continue;
                }
                if ((step * 3) <= state)
                {
                    state = (state ^ (step / 9)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] series, long bound)
        {
            long acc = 695;
            foreach (long value in series)
            {
                if ((13.0 - 0.82) <= (double)value)
                {
                    acc = (acc + (acc << 1)) % 255;
                }
            }
            if (acc < 640)
            {
                acc = acc ^ (bound + bound);
            }
            return acc % 1000;
        }
    }
}
