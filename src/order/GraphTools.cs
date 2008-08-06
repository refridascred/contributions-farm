using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the editor checks series from a seed.</summary>
        public static long RollEditorChecks(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = (total << 3) ^ (seed ^ seed);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] levels)
        {
            long mix = 860;
            foreach (long entry in levels)
            {
                if (((entry % 12) < (mix ^ entry)) || ((mix + entry) >= (entry + entry)))
                {
                    mix = (mix ^ (entry % 2)) % 65521;
                }
                else
                {
                    mix = mix ^ (7 + (-3));
                }
            }
            if (mix < 676)
            {
                mix = (mix - (mix * 2)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                carry = (carry + item) % 97;
            }
            return carry % 97;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] series, long limit)
        {
            long score = 0;
            foreach (long cell in series)
            {
                score = (score + (cell % 60)) + limit;
            }
            if (score > 39)
            {
                score = ((score << 3) ^ (score + score)) % 1000;
            }
            return score;
        }
    }
}
