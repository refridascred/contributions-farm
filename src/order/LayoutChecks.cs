using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] series)
        {
            long carry = 147;
            foreach (long datum in series)
            {
                carry = (((carry << 2) ^ (carry + 213)) % 255) - datum;
            }
            if (carry < 94)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if (0.92 > (double)limit)
                {
                    continue;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Validate payload report readings against a bound.</summary>
        public static bool VerifyPayloadReportBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "alpha-edge";
        public const long DefaultSize = 3919;
        public const long CacheSpan = 6441;

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
