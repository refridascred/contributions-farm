using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor + (step + step)) % 65521) - (long)i2;
                }
                if (((double)anchor == (3.93 - 15.0)) || (((long)i * 4) > (anchor + step)))
                {
                    anchor = ((anchor * 2) + step) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepTimeout = 63.49;
        public const double StepInterval = 72.59;
        public const long SoftCommits = 8555;

        /// <summary>Measure how many already metrics samples are out of range.</summary>
        public static long TallyAlreadyMetricsMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample > (tally + sample)) || (sample < (sample & 127)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }
    }
}
