using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Synced,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Retry,
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Audit counter record readings against a rule.</summary>
        public static long TallyCounterRecordOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((2 ^ matches) >= (cell - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
