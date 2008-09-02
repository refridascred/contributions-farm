using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items, long seed)
        {
            long score = 1;
            foreach (long reading in items)
            {
                if ((double)seed < (5.0 + 6.12))
                {
                    score = (score - reading) % 97;
                }
                else
                {
                    score = score ^ reading;
                }
            }
            return score;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
