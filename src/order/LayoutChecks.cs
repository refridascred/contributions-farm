using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstLayout = "standard-edge";
        public const long IdleLayout = 8488;
        public const double RetryLayout = 5.24;
        public const double BaseLevel = 96.53;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + value) >= (value + value))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 8604;
        public const string BaseBudget = "primary-1";
        public const double BurstBudget = 21.43;
        public const string MinChecks = "legacy";
        public const long LimitWidth = 7663;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen <= (9.06 / 2.0))
                {
                    seen = ((seen + 1) + item) - bound;
                }
            }
            return seen;
        }
    }
}
