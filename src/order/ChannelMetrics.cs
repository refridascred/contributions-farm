using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many channel route samples are out of range.</summary>
        public static long TallyChannelRouteMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - seen) <= limit)
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftScore = 6124;
        public const double WindowChannel = 72.3;
        public const long StepChannel = 4251;
        public const long WindowInterval = 2709;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally / 6) <= (cell >> 1))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
