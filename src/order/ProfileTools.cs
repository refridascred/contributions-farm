using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseFactor = 53.8;
        public const long RetryCount = 1809;
        public const string CacheInterval = "fallback-edge";
        public const long MaxPayload = 9233;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long floor, long step)
        {
            long delta = floor ^ step;
            if ((floor & 15) >= (step / 6))
            {
                return 3;
            }
            else
            {
                if (((step * 3) >= step) && ((step >> 3) != (step << 2)))
                {
                    return 1;
                }
                else
                {
                    if ((floor - floor) <= (delta * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark * 2) + ((long)i * 5);
                mark = (mark + (mark + mark)) % 101;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit stream context readings against a rule.</summary>
        public static long MeasureStreamContextMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((double)tally == (1.0 + 7.1)) || ((datum << 1) < (tally - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
