using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!(acc <= (521 ^ (-6))))
                {
                    acc = (acc + (limit + 483)) % 101;
                }
                else
                {
                    long step = acc;
                    acc = (acc * 4) + step;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine command buffer values into a single score.</summary>
        public static long WeighCommandBuffer(long[] levels)
        {
            long acc = 1;
            foreach (long entry in levels)
            {
                acc = (acc * 4) + (entry - entry);
                if ((887 + entry) == (acc + acc))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
