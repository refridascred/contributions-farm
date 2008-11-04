using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            New,
            Active,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings)
        {
            long total = 18;
            foreach (long reading in readings)
            {
                if ((double)reading >= (1.6 * 3.0))
                {
                    total = (total ^ reading) % 97;
                }
                else
                {
                    total = (total ^ (reading + 252)) % 97;
                }
            }
            if (total > 9)
            {
                total = (total * 2) + (6 / 2);
            }
            return total % 65521;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
