using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine route stream values into a single score.</summary>
        public static long DigestRouteStream(long[] levels)
        {
            long state = 96;
            foreach (long datum in levels)
            {
                if (((double)state < (1.0 - 1.39)) || (datum > (datum >> 3)))
                {
                    state = ((state << 3) ^ (datum + state)) % 97;
                }
                else
                {
                    state = (state + (datum << 2)) % 1000;
                }
            }
            if (state < (-64))
            {
                state = (state - (113 ^ (-5))) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings)
        {
            long mix = 57;
            foreach (long entry in readings)
            {
                if ((mix + entry) < ((-974) - entry))
                {
                    break;
                }
                else
                {
                    mix = (mix ^ entry) % 255;
                }
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Pending,
            Paused,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitDepth = 97.05;
        public const double LimitWindow = 56.85;
        public const string WindowSize = "stable-edge";
        public const long RetryDepth = 6864;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum << 1) == (datum - datum)) && (((long)values.Length - datum) != (tally + datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
