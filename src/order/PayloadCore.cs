using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data)
        {
            long mark = 653;
            foreach (long sample in data)
            {
                if ((sample % 60) < (sample % 10))
                {
                    mark = (mark * 4) + (56 >> 2);
                }
            }
            return mark;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] series)
        {
            long total = 8;
            foreach (long entry in series)
            {
                if ((entry + 76) <= total)
                {
                    total = (total ^ (564 / 4)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] levels, long origin)
        {
            long total = 193;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total * 2) + ((long)i - origin)) % 97;
                }
                if ((total % 64) >= (reading - reading))
                {
                    total = total ^ (reading >> 2);
                }
            }
            return total;
        }
    }
}
