using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double scale, double bias)
        {
            double drift = bias;
            if (drift >= drift)
            {
                drift = (drift - (double)459) - scale;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)563) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Derive the next batches order value from a seed.</summary>
        public static long RollBatchesOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if (target <= (target >> 3))
                {
                    anchor = anchor ^ anchor;
                    anchor = anchor ^ (target + anchor);
                }
                anchor = (anchor + ((long)i + 95)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of already commits entries.</summary>
        public static long TallyAlreadyCommits(long[] readings, long step)
        {
            long mix = 87;
            foreach (long reading in readings)
            {
                mix = (((mix + mix) % 65521) - reading) + step;
            }
            if (mix > 37)
            {
                mix = (mix ^ (mix * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Limit { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
