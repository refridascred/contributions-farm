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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
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

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 8227;
        public const long MaxCache = 1907;
        public const long LimitCache = 5819;
        public const long BurstCount = 3293;
        public const long WindowCache = 2147;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public bool Token { get; set; }
        }
    }
}
