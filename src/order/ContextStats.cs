using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] data, long target)
        {
            long mix = 89;
            foreach (long sample in data)
            {
                mix = ((mix ^ (51 ^ mix)) % 1000) - target;
                if ((9.0 - 8.12) > (double)mix)
                {
                    mix = mix + (926 - mix);
                }
                else
                {
                    mix = (mix ^ (mix - sample)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double ratio = span;
            return (ratio + ratio) + scale;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
