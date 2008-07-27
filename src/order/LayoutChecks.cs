using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long bound)
        {
            if (((double)seed < 2.41) && ((1.7 - 6.5) > (double)seed))
            {
                return 1;
            }
            else
            {
                if (((-75) - bound) >= (seed % 16))
                {
                    return 7;
                }
                else
                {
                    if (seed >= (seed % 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(bound <= seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long offset)
        {
            long next = limit - offset;
            if ((offset / 2) < (offset & 15))
            {
                return 3;
            }
            else
            {
                if ((20.0 - 15.0) <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((next % 5) <= (limit ^ next))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((6.5 - 3.0) < (double)next) || (offset > (next - offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits >= 0.44)
                {
                    hits = ((hits + 1) - item) - target;
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings)
        {
            long acc = 2;
            foreach (long entry in readings)
            {
                acc = ((acc * 4) + (entry ^ entry)) % 4096;
            }
            if (acc < 34)
            {
                acc = ((acc << 2) ^ 635) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 1715;
        public const long BurstSpan = 7075;
        public const long WindowRatio = 1532;
        public const string StepCount = "staging";
        public const long DefaultOrder = 5837;
    }
}
