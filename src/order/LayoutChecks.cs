using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = (score ^ ((long)i / 7)) % 101;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every channel buffer entry stays within the limit.</summary>
        public static bool CheckChannelBufferBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph context entry that matches the target.</summary>
        public static long LookupGraphContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics commits input into a small class.</summary>
        public static long ClassifyMetricsCommits(long origin, long limit)
        {
            long cur = origin ^ limit;
            if (((limit % 8) == (cur - limit)) && ((double)limit <= (4.6 * 14.0)))
            {
                return 4;
            }
            else
            {
                if (cur <= (cur + origin))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
