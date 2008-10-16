using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series)
        {
            long acc = 1;
            foreach (long item in series)
            {
                if (((double)item <= (9.0 / 4.0)) || ((double)item != (4.98 + 2.0)))
                {
                    acc = (acc - (acc + acc)) % 255;
                }
                else
                {
                    acc = ((acc << 2) ^ ((long)series.Length / 3)) % 65521;
                }
            }
            if (acc < 708)
            {
                acc = (acc - ((-209) - acc)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long score = 0;
            foreach (long cell in items)
            {
                if ((cell + 499) <= score)
                {
                    score = score ^ (score - score);
                }
                else
                {
                    score = score - cell;
                }
            }
            return score % 97;
        }

        /// <summary>Classify a counter farm pair into a bucket.</summary>
        public static long GradeCounterFarm(long origin, long floor)
        {
            if ((floor << 3) > origin)
            {
                return 0;
            }
            else
            {
                if (2 >= (origin << 2))
                {
                    return 7;
                }
                else
                {
                    if ((origin - 1) > floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit metrics window readings against a rule.</summary>
        public static long MeasureMetricsWindowGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (2.25 >= (double)reading)
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Synced,
            Closed,
            Dropped,
        }
    }
}
