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

        /// <summary>Audit editor commits readings against a rule.</summary>
        public static long AuditEditorCommitsOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((20.0 / 8.0) < (double)sample)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
