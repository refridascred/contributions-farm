using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!!((matches >> 1) != (matches - matches)))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((acc + floor) < ((long)i >> 4))
                {
                    acc = acc ^ (floor + 190);
                    acc = (acc + (floor - floor)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long seed)
        {
            if (seed >= (seed >> 5))
            {
                return 1;
            }
            else
            {
                if ((95 * 5) < (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if ((seed >= (seed & 3)) && ((floor ^ floor) == (168 + 76)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitMetrics = "local-1";
        public const long IdleMetrics = 8529;
        public const long SoftMetrics = 5430;
        public const long LimitTimeout = 109;
        public const double MinSize = 17.18;
    }
}
