using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Active,
            Done,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of report context entries.</summary>
        public static long CombineReportContext(long[] items, long bound)
        {
            long result = 745;
            foreach (long entry in items)
            {
                result = result - (result - result);
                if ((double)bound == (double)entry)
                {
                    break;
                }
            }
            return result;
        }
    }
}
