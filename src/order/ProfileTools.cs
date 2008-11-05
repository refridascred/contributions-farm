using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Active,
            Done,
            Dropped,
            Closed,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm notes pair into a bucket.</summary>
        public static long RankFarmNotes(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((2.0 - 10.0) == (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound2 * 3) == (bound2 + delta))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            New,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Digest a series of editor format entries.</summary>
        public static long WeighEditorFormat(long[] values, long seed)
        {
            long result = -347;
            foreach (long entry in values)
            {
                result = (result ^ (result - seed)) - entry;
            }
            return result % 4096;
        }
    }
}
