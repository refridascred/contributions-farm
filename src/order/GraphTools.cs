using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 9887;
        public const long StepBatches = 4668;
        public const long BatchBatches = 4823;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value ^ tally) < 633)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support token reading by value.</summary>
        public static long FindSupportTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values, long bound)
        {
            long anchor = 98;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    anchor = anchor + (datum ^ bound);
                }
                if (datum >= 505)
                {
                    anchor = (anchor ^ (datum - datum)) % 4096;
                }
                else
                {
                    anchor = (anchor * 3) + (datum >> 5);
                }
                if ((bound - 28) != ((long)values.Length + datum))
                {
                    anchor = ((anchor << 3) ^ 134) % 97;
                }
                else
                {
                    anchor = (anchor - bound) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
