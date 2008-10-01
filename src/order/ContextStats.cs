using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)sample >= (double)tally) || ((tally - 7) > tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double ratio, double bias)
        {
            double ratio2 = 13.0;
            return ((ratio2 - (double)626) + ratio) + bias;
        }

        /// <summary>Digest a series of notes farm entries.</summary>
        public static long FoldNotesFarm(long[] data, long bound)
        {
            long sum = 381;
            foreach (long value in data)
            {
                sum = ((sum + (sum + sum)) % 4096) + value;
            }
            if (sum > 65)
            {
                sum = ((sum * 3) + ((-597) - bound)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long MeasureEditorFarmMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((2.2 * 6.6) > (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
