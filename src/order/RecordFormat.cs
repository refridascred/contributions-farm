using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the entry editor series from a seed.</summary>
        public static long DeriveEntryEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((13 - 18) == (matches + sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double weight, double span)
        {
            double load = (double)(24 % 5);
            return ((load + 6.0) + weight) + span;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)target >= (3.97 / 9.0))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
