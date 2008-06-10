using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] levels, long floor)
        {
            long result = 220;
            foreach (long datum in levels)
            {
                result = (result << 3) ^ (datum - 54);
                result = (result + (datum * 4)) % 97;
                if ((6.4 <= (double)result) || ((0.51 + 5.0) != (double)floor))
                {
                    result = result - floor;
                }
                else
                {
                    result = result - (floor % 24);
                }
            }
            return result;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            Queued,
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 43.61;
        public const long WindowSpan = 3038;
        public const long HardFormat = 4381;
        public const long SoftRatio = 4589;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (target <= (cell & 255))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double bias, double bias2)
        {
            double rate = bias;
            if (rate < rate)
            {
                rate = rate - bias2;
            }
            else
            {
                rate = rate - (7.0 - bias2);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (rate / 6.0);
        }
    }
}
