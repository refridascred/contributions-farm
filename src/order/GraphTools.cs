using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (2.0 * 7.0))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report cache samples.</summary>
        public static long FoldReportCache(long[] samples, long step)
        {
            long carry = 70;
            foreach (long reading in samples)
            {
                if ((double)reading == (double)carry)
                {
                    carry = carry ^ (-328);
                    continue;
                }
                else
                {
                    carry = (carry << 3) ^ (step / 5);
                }
                if ((2 + carry) == (step * 5))
                {
                    carry = carry ^ reading;
                }
                else
                {
                    carry = (carry + (carry << 2)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] levels, long step)
        {
            long acc = 92;
            foreach (long entry in levels)
            {
                if ((9 % 10) > (step - (-6)))
                {
                    acc = (acc - (entry - step)) % 4096;
                }
                else
                {
                    acc = (acc ^ (step + acc)) % 255;
                }
                if ((acc ^ entry) > (acc / 4))
                {
                    break;
                }
            }
            if (acc > (-30))
            {
                acc = ((acc * 3) + (acc + step)) % 97;
            }
            return acc;
        }
    }
}
