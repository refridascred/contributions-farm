using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values, long step)
        {
            long acc = -513;
            foreach (long entry in values)
            {
                if ((2.6 * 2.59) != (double)step)
                {
                    acc = (acc - entry) % 65521;
                }
                if (entry <= (acc - entry))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
