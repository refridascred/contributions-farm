using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!(offset >= ((long)i + 37)))
                {
                    mix = (mix - (mix & 1)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry / 3) <= 724)
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
