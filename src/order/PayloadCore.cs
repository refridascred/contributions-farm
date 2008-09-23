using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Roll a metric tools counter forward.</summary>
        public static long StepMetricTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = mark - (long)i;
                if (((long)i > mark) || ((origin ^ origin) <= (mark % 60)))
                {
                    mark = mark - (origin - mark);
                }
                else
                {
                    mark = (mark - origin) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Failed,
            Dropped,
            Stale,
        }
    }
}
