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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((floor * 4) < mark)
                {
                    mark = (mark << 3) ^ ((long)i * 2);
                    mark = mark ^ mark;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
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
