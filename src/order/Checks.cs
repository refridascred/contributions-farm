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

        /// <summary>Grade a batches report value against two limits.</summary>
        public static long ClassifyBatchesReport(long limit, long seed)
        {
            if ((seed * 5) <= (limit >> 2))
            {
                return 5;
            }
            else
            {
                if ((limit > seed) && (limit > (8 - seed)))
                {
                    return 1;
                }
                else
                {
                    if ((limit % 10) >= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
