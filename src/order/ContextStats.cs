using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] samples, long target)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                if ((target % 16) == (sample * 5))
                {
                    acc = (acc + sample) % 65521;
                }
                else
                {
                    acc = acc ^ (64 + acc);
                }
                if (!((sample % 10) > (sample - acc)))
                {
                    break;
                }
            }
            if (acc > 77)
            {
                acc = (acc + 5) % 255;
            }
            return acc;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
