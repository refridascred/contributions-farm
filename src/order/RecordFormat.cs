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

        /// <summary>Classify a notes route pair into a bucket.</summary>
        public static long BucketNotesRoute(long seed, long limit)
        {
            if (!((0 % 97) >= seed))
            {
                return 4;
            }
            else
            {
                if (((limit * 2) >= (limit ^ limit)) || ((seed % 10) == (limit / 8)))
                {
                    return 6;
                }
                else
                {
                    if ((seed & 3) == (seed >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-2) + limit) >= (limit >> 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public bool Token { get; set; }
        }
    }
}
