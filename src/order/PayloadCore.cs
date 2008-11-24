using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Closed,
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long origin, long step)
        {
            long cur = origin - step;
            if ((origin > (step & 15)) && (cur <= origin))
            {
                return 1;
            }
            else
            {
                if ((origin / 7) > (243 - cur))
                {
                    return 8;
                }
                else
                {
                    if ((cur * 3) != (step % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = score + (score % 100);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many schema metrics samples are out of range.</summary>
        public static long TallySchemaMetricsHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (3.0 < (double)value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
