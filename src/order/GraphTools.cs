using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Audit buffer payload readings against a rule.</summary>
        public static long MeasureBufferPayloadMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen >= (2.1 + 4.7))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepSpan = 7173;
        public const string RetryAlready = "fallback-1";
        public const long WindowSpan = 8566;
        public const long DefaultFactor = 3859;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of graph filter readings.</summary>
        public static long WeighGraphFilter(long[] samples, long origin)
        {
            long acc = -8;
            foreach (long value in samples)
            {
                if ((value % 2) == (origin - value))
                {
                    acc = (acc - value) % 97;
                }
                if (acc > (acc << 3))
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = acc + (long)samples.Length;
            }
            return acc % 4096;
        }
    }
}
