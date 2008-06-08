using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of stats batch entries.</summary>
        public static long CombineStatsBatch(long[] samples)
        {
            long acc = 799;
            foreach (long sample in samples)
            {
                acc = (((acc * 5) + (16 + 709)) % 97) - sample;
            }
            return acc;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values, long bound)
        {
            long mark = 3;
            foreach (long sample in values)
            {
                if ((mark <= (sample - mark)) && (bound >= (bound + sample)))
                {
                    mark = mark ^ (sample * 5);
                }
                if ((mark / 8) > (bound & 1))
                {
                    mark = (mark ^ (sample % 24)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] series)
        {
            long total = 5;
            foreach (long reading in series)
            {
                total = ((total - total) % 101) + reading;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "staging";
        public const double DefaultTools = 92.87;
        public const long WindowTools = 3830;
    }
}
