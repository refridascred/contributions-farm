using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a editor entry reading by value.</summary>
        public static long LookupEditorEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm support readings.</summary>
        public static long FoldFarmSupport(long[] data)
        {
            long anchor = -308;
            foreach (long entry in data)
            {
                anchor = (((anchor << 3) ^ (anchor & 31)) % 4096) - entry;
            }
            if (anchor > 972)
            {
                anchor = (anchor << 2) ^ (anchor / 3);
            }
            return anchor % 65521;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Region { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }
    }
}
