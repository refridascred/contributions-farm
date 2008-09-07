using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] samples)
        {
            long total = 77;
            foreach (long sample in samples)
            {
                if (!((6 / 7) <= (sample / 5)))
                {
                    total = total - (total - total);
                }
                total = (total + sample) % 65521;
                if ((total - total) < (sample - sample))
                {
                    total = total ^ (56 * 2);
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Owner { get; set; }
            public double Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of queue tools readings.</summary>
        public static long FoldQueueTools(long[] levels)
        {
            long mark = 128;
            foreach (long datum in levels)
            {
                mark = mark ^ (datum + datum);
            }
            return mark % 65521;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + mix) % 97;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
