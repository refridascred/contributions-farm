using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((24 < (limit / 7)) || ((limit % 24) > limit))
            {
                return 2;
            }
            else
            {
                if ((limit ^ origin) > prev)
                {
                    return 3;
                }
                else
                {
                    if (((double)limit <= (16.0 + 11.0)) || (origin <= (7 * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + prev) < (prev - limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] levels, long offset)
        {
            long sum = 290;
            foreach (long datum in levels)
            {
                if ((double)offset < (10.0 - 9.8))
                {
                    sum = (((sum << 2) ^ (offset / 2)) % 101) ^ datum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((tally << 3) <= (tally - value)) && (((7 * 3) != (tally / 8)) && (value >= tally)))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "stable";
        public const string BurstSession = "standard-edge";
        public const long IdleDepth = 8975;
    }
}
