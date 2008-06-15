using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the tools commits series from a seed.</summary>
        public static long IterateToolsCommits(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((mix ^ mix) >= ((-960) - mix))
                {
                    mix = ((mix * 2) + (floor + mix)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Adjust a checks notes reading.</summary>
        public static double BlendChecksNotes(double ratio, double span)
        {
            double scale = (double)(0 - (-71));
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (double)(long)i) - ratio) + span;
            }
            return scale + (scale * 3.84);
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a order queue counter forward.</summary>
        public static long RollOrderQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!(((long)i + score) <= (limit + (-67))))
                {
                    score = (score - (score + limit)) % 4096;
                }
                if (((score - 80) >= score) && ((double)limit <= (double)(long)i))
                {
                    score = (score + (long)i) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
