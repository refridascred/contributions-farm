using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a tools already pair into a bucket.</summary>
        public static long ClassifyToolsAlready(long offset, long bound)
        {
            if ((1 ^ offset) != (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((bound * 4) != (offset + bound))
                {
                    return 7;
                }
                else
                {
                    if (offset <= (offset & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)bound < 5.79) && ((offset / 9) != (offset - bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools batch pairs that satisfy a relation.</summary>
        public static long PairToolsBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
