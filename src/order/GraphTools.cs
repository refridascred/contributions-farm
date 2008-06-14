using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Failed,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Project the next checks buffer value.</summary>
        public static double ProjectChecksBuffer(double ratio, double offset)
        {
            double load = (double)8 + (double)803;
            return (load - ratio) + offset;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long bound)
        {
            if ((7 - 29) > bound)
            {
                return 2;
            }
            else
            {
                if (((bound / 6) <= (bound + 9)) || (step <= (bound + bound)))
                {
                    return 4;
                }
                else
                {
                    if (!((bound - 5) > (2 << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
