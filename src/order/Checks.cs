using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally - tally) > (offset >> 2))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i ^ (-408)) <= step)
                {
                    long span = (step ^ step) & 63;
                    mark = (mark + span) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark & 255)) % 1000;
                }
                mark = ((mark * 5) + mark) % 1000;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Active,
            Paused,
            Done,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "standard-edge";
        public const long RetryToken = 7714;
        public const string HardToken = "primary";

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
