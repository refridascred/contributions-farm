using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value << 2) >= (tally >> 5))
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

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double bias, double bias2)
        {
            double scale = (double)7 - (double)0;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)(long)i) - bias;
            }
            return scale + (bias2 / 5.0);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((3.5 / 3.0) != (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
