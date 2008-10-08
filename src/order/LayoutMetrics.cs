using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long limit, long limit2)
        {
            if (((limit2 ^ limit2) == (limit2 - limit)) || (limit2 >= (869 ^ 27)))
            {
                return 1;
            }
            else
            {
                if ((11.0 - 9.53) > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((limit2 + limit) >= (925 & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((816 % 12) < (limit2 - limit2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
