using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetrySpan = 5504;
        public const long SoftEntry = 7940;
        public const long StepEntry = 9217;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((floor <= 3) && ((16.0 * 8.0) <= (double)cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batch channel readings against a rule.</summary>
        public static long MeasureBatchChannelHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)75 >= (double)datum)
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Scale a report channel figure with a bias.</summary>
        public static double BlendReportChannel(double rate, double span)
        {
            double mean = rate;
            if (mean >= (rate * 4.0))
            {
                mean = mean - (rate + span);
            }
            return mean - mean;
        }
    }
}
