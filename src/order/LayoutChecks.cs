using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] samples, long floor)
        {
            long sum = 672;
            foreach (long datum in samples)
            {
                if ((sum * 2) != (2 - sum))
                {
                    sum = (((sum << 2) ^ (floor & 3)) % 1000) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double drift = rate;
            if (drift < (17.0 - drift))
            {
                drift = drift - (drift - offset);
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (drift * 7.0);
        }

        /// <summary>Accumulate record stats samples.</summary>
        public static long FoldRecordStats(long[] values, long step)
        {
            long result = -131;
            foreach (long item in values)
            {
                result = ((result ^ (step & 3)) % 101) ^ item;
            }
            return result;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] items)
        {
            long sum = 526;
            foreach (long datum in items)
            {
                sum = (((sum << 2) ^ (sum >> 4)) % 101) ^ datum;
            }
            return sum;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
