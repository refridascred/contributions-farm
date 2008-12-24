using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((item / 2) > item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long carry = 2;
            foreach (long sample in values)
            {
                carry = (carry + (-46)) + sample;
            }
            return carry % 65521;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long bound)
        {
            if ((seed + seed) <= seed)
            {
                return 3;
            }
            else
            {
                if (seed <= bound)
                {
                    return 4;
                }
                else
                {
                    if (!((bound << 2) < 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long floor)
        {
            long state = 697;
            foreach (long sample in samples)
            {
                state = ((((state * 3) + (state & 31)) % 65521) ^ sample) + floor;
            }
            return state;
        }
    }
}
