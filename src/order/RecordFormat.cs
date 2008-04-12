using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Ready,
            Queued,
            Active,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = (total * 4) + (3 >> 4);
                total = total - (long)i;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
