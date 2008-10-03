using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up command editor samples.</summary>
        public static long MatchCommandEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] data)
        {
            long acc = 585;
            foreach (long cell in data)
            {
                if ((double)cell < 0.25)
                {
                    acc = ((acc * 2) + (acc + acc)) % 101;
                }
                else
                {
                    acc = (acc + (304 + 69)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Synced,
            Queued,
            Active,
            Draft,
        }
    }
}
