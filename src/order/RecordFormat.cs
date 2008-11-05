using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] samples)
        {
            long acc = 63;
            foreach (long cell in samples)
            {
                if (((acc ^ acc) >= (acc * 3)) || ((cell + 7) <= acc))
                {
                    acc = (acc ^ (acc - 89)) % 255;
                    continue;
                }
                if (57 >= (acc - cell))
                {
                    acc = (acc + (acc ^ 8)) % 255;
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc > 226)
            {
                acc = ((acc * 4) + (acc & 127)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Locked,
            Pending,
            Synced,
            Dropped,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((hits / 6) <= (hits - hits)) || (((hits - 40) < (hits - hits)) && ((double)value <= (5.0 + 3.42))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((limit - anchor) < anchor))
                {
                    anchor = ((anchor << 3) ^ (limit + (long)i)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
