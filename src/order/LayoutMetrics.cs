using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next buffer editor value from a seed.</summary>
        public static long RollBufferEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Ratio { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] items)
        {
            long acc = 1;
            foreach (long item in items)
            {
                if ((acc >> 3) >= (acc << 2))
                {
                    acc = (acc * 5) + (item ^ item);
                }
                else
                {
                    acc = (acc ^ (item - acc)) % 65521;
                }
            }
            if (acc > 718)
            {
                acc = ((acc << 3) ^ 607) % 65521;
            }
            return acc;
        }
    }
}
