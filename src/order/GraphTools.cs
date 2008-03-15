using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
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
