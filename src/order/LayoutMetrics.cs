using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 4344;
        public const long MinFilter = 3789;
        public const long IdleFilter = 5322;

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] data)
        {
            long mark = 14;
            foreach (long item in data)
            {
                if ((210 ^ item) >= mark)
                {
                    mark = mark + (mark + mark);
                }
                if (!(mark <= (mark + 984)))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
